# Charge-attempt JSON round-trip reproduction

These tests use synthetic API responses and never contact a Wallee API. Both projects compile the same assertions so that the package versions are compared at the same boundary: deserialize a successful charge attempt and serialize the resulting SDK model as an export record.

```sh
dotnet test tests/serialization-roundtrip/legacy/Legacy.Tests.csproj
dotnet test tests/serialization-roundtrip/v2/V2.Tests.csproj
```

The legacy project references Wallee 9.1.0 and passes. The v2 project references Wallee 10.4.0: its default-serialization tests intentionally fail because IDs and timestamps are omitted. Its export-only contract-resolver test passes. The same two failures occur when testing the checkout at `9a7df16` with `UseLocalSdk=true`.

For example, the physical-presence test deserializes a synthetic response containing an attempt ID, creation and success timestamps, and nested IDs. The tests assert these fields are present on the model before serializing it. With Json.NET's default settings, the result differs:

Wallee 9.1.0 (abbreviated):

```json
{"id":101,"createdOn":"2025-01-15T12:34:56Z","succeededOn":"2025-01-15T12:34:57Z","charge":{"id":201},"terminal":{"id":301},"invocation":{"id":401},"connectorConfiguration":{"id":501}}
```

Wallee 10.4.0 (complete output):

```json
{"state":"SUCCESSFUL","completionBehavior":"COMPLETE_IMMEDIATELY","environment":"PRODUCTION","customersPresence":"PHYSICAL_PRESENT","charge":{},"terminal":{},"invocation":{},"connectorConfiguration":{}}
```

The v2 model's `ShouldSerialize...` methods cause Json.NET to omit those response fields when writing the model. The failure demonstrates an export round-trip use case; it does not mean that read-only fields should be sent in API requests. The tests simulate a consumer using default Json.NET serialization, so a specific exporter's actual serialization path still needs to be verified.

To run the v2 tests against this checkout instead of the published 10.4.0 package:

```sh
dotnet test tests/serialization-roundtrip/v2/V2.Tests.csproj -p:UseLocalSdk=true
```

These are reproduction tests, and the v2 default-serialization tests are expected to remain red until the corresponding behavior or export contract is addressed. The export-only setting can also expose default-valued properties that were absent from the original response, so consumers must validate the full output format.
