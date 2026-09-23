using Keyfactor.Platform.ICertificateStoreTypeMigrationHandler;
using Keyfactor.Platform.ICertificateStoreTypeMigrationHandler.Models;

namespace RemoteFileTypeHandlers.RFPEM
{
    internal class RFPEMCertificateStoreMigrationHandler : ICertificateStoreMigrationHandler
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MigrationParameterDelta>> GetCertificateStoreTypeDifferencesAsync(IEnumerable<CertificateStoreTypeSnapshot> storeTypeSnapshots, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MigrationResult>> MigrateAsync(IEnumerable<CertificateStoreSnapshot> certificateStores, IEnumerable<CertificateStorePropertyDiff> updatedProperties, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
