using Keyfactor.Platform.ICertificateStoreTypeMigrationHandler;
using Keyfactor.Platform.ICertificateStoreTypeMigrationHandler.Models;

namespace RemoteFileTypeHandlers.RFJKS
{
    internal class RFJKSCertificateStoreMigrationHandler : ICertificateStoreMigrationHandler
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
