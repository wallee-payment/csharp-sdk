using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Wallee.Model;

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
        /// <exception cref="Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="content">Content to verify.</param>
        /// <param name="contentSignature">Base64 encoded signature of the content.</param>
        /// <param name="publicKey">The public key (WebhookEncryptionPublicKey)</param>
        /// <param name="signatureAlgorithm">Algorithm of a signature</param>
        /// <returns>true if content is confirmed by the signature</returns>
        public static bool IsContentValid(string content, string contentSignature, WebhookEncryptionPublicKey publicKey,
            string signatureAlgorithm)
        {
            bool result;
            switch (signatureAlgorithm)
            {
                case "SHA256withECDSA":
                    result = VerifySignatureWithECDSA(content, contentSignature, publicKey.PublicKey);
                    break;
                default:
                    throw new NotSupportedException("Unknown signature algorithm: " + signatureAlgorithm);
            }

            return result;
        }

        private static bool VerifySignatureWithECDSA(string content, string contentSignature, string publicKey)
        {
            ECPublicKeyParameters publicKeyParameters = ImportEcdsaPublicKeyParameters(publicKey);
            ISigner signer = SignerUtilities.GetSigner("SHA-256withECDSA");
            signer.Init(false, publicKeyParameters);
            signer.BlockUpdate(Encoding.UTF8.GetBytes(content), 0, content.Length);
            return signer.VerifySignature(GetSignatureBytes(contentSignature));
        }

        private static ECPublicKeyParameters ImportEcdsaPublicKeyParameters(string base64EncodedPublicKey)
        {
            byte[] publicKeyBytes = Convert.FromBase64String(base64EncodedPublicKey);
            return (ECPublicKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
        }

        private static byte[] GetSignatureBytes(string contentSignature)
        {
            try
            {
                return Convert.FromBase64String(contentSignature);
            }
            catch (FormatException e)
            {
                throw new InvalidDataException("Content signature is not a valid BASE-64 string", e);
            }
        }
    }
}
