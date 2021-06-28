using BL.Bases;
using BL.ViewModel;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repositories
{
    public class CertificateRepository: BaseRepository<Certificate>
    {

        private DbContext certificateContext;
        public CertificateRepository(DbContext certificateContext):base(certificateContext)
        {
            this.certificateContext = certificateContext;
        }

        public List<Certificate> GetAllCertificate()
        {
            return GetAll().ToList();
        }

        public bool InsertCertificate(Certificate certificate)
        {
            return Insert(certificate);
        }
        public void UpdateCertificate(Certificate certificate)
        {
            Update(certificate);
        }
        public void DeleteCertificate(int id)
        {
            Delete(id);
        }

        public bool CheckIsCertificateExists(Certificate certificate)
        {
            return GetAny(cert => cert.CertificateID == certificate.CertificateID);
        }
        public Certificate GetCertificateById(int id)
        {
            return GetFirstOrDefault(cert => cert.CertificateID == id);
        }

    }
}
