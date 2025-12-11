/**
 * Wallee AG C# SDK
 *
 * This library allows to interact with the Wallee AG payment service.
 *
 * Copyright owner: Wallee AG
 * Website: https://en.wallee.com
 * Developer email: ecosystem-team@wallee.com
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Wallee.Model;
using Wallee.Client;

namespace Wallee.Util
{
    /// <summary>
    /// Helper utility for dealing with encryption
    /// </summary>
    public static class EncryptionUtil
    {
        /// <summary>
        /// IsContentValid Validate the content using the signature and public key.
        /// </summary>
        /// <exception cref="Wallee.Client.WalleeSdkException">Thrown when signature validation fails</exception>
        /// <param name="content">Content to verify.</param>
        /// <param name="contentSignature">Base64 encoded signature of the content.</param>
        /// <param name="publicKey">The public key</param>
        /// <param name="signatureAlgorithm">Algorithm of a signature</param>
        /// <returns>true if content is confirmed by the signature</returns>
        public static bool IsContentValid(string content, string contentSignature, string publicKey,
                                          string signatureAlgorithm)
        {

            if (String.IsNullOrEmpty(signatureAlgorithm))
            {
                throw new WalleeSdkException(
                    SdkExceptionErrorCodes.MISSING_WEBHOOK_ENCRYPTION_ALGORYTHM,
                    "Webhook signature algorythm was not provided");
            }

                switch (signatureAlgorithm)
                {
                    case "SHA256withECDSA":
                        return VerifySignatureWithECDSA(content, contentSignature, publicKey);
                    default:
                        throw new WalleeSdkException(
                            SdkExceptionErrorCodes.UNSUPPORTED_WEBHOOK_ENCRYPTION_ALGORYTHM,
                            $"Unknown signature algorithm: {signatureAlgorithm}. "
                            + "This may indicate that the REST API is using a new encryption algorithm for webhooks. "
                            + "Please check whether a newer version of the SDK is available.");
                }
        }

        private static bool VerifySignatureWithECDSA(string content, string contentSignature, string publicKey)
        {
            try
            {
                ECPublicKeyParameters publicKeyParameters = ImportEcdsaPublicKeyParameters(publicKey);
                ISigner signer = SignerUtilities.GetSigner("SHA-256withECDSA");
                signer.Init(false, publicKeyParameters);
                signer.BlockUpdate(Encoding.UTF8.GetBytes(content), 0, content.Length);
                return signer.VerifySignature(GetSignatureBytes(contentSignature));
            }
            catch (InvalidDataException ex)
            {
                throw new WalleeSdkException(
                    SdkExceptionErrorCodes.INVALID_WEBHOOK_ENCRYPTION_CONTENT_SIGNATURE,
                    "Invalid content signature format: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new WalleeSdkException(
                    SdkExceptionErrorCodes.WEBHOOK_ENCRYPTION_SIGNATURE_VERIFICATION_FAILED,
                    "Failed to verify ECDSA signature because: " + ex.Message);
            }
        }

        private static ECPublicKeyParameters ImportEcdsaPublicKeyParameters(string base64EncodedPublicKey)
        {
            try
            {
                byte[] publicKeyBytes = Convert.FromBase64String(base64EncodedPublicKey);
                return (ECPublicKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
            }
            catch (Exception ex)
            {
                throw new WalleeSdkException(
                    SdkExceptionErrorCodes.INVALID_WEBHOOK_ENCRYPTION_PUBLIC_KEY,
                    "Invalid public key: " + ex.Message);
            }
        }

        private static byte[] GetSignatureBytes(string contentSignature)
        {
            try
            {
                return Convert.FromBase64String(contentSignature);
            }
            catch (FormatException ex)
            {
                throw new WalleeSdkException(
                    SdkExceptionErrorCodes.INVALID_WEBHOOK_ENCRYPTION_CONTENT_SIGNATURE,
                    "Content signature is not a valid BASE-64 string: " + ex.Message);
            }
        }
    }
}
