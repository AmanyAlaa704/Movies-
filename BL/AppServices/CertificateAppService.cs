using BL.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BL.ViewModel;

namespace BL.AppServices
{
    public class CertificateAppService : AppServiceBase
    {

        public List<CertificateViewModel> GetAllCertificates()
        {

            return Mapper.Map<List<CertificateViewModel>>(TheUnitOfWork.Certificate.GetAllCertificate());
        }
        public CertificateViewModel GetCertificate(int id)
        {
            return Mapper.Map<CertificateViewModel>(TheUnitOfWork.Certificate.GetCertificateById(id));
        }

        public bool SaveNewCertificate(CertificateViewModel certificateViewModel)
        {
            bool result = false;
            var certificate = Mapper.Map<Certificate>(certificateViewModel);
            if (TheUnitOfWork.Certificate.Insert(certificate))
            {
                result = TheUnitOfWork.Commit() > new int();
            }
            return result;
        }

        public bool UpdateCertificate(CertificateViewModel certificateViewModel)
        {
            var certificate = Mapper.Map<Certificate>(certificateViewModel);
            TheUnitOfWork.Certificate.Update(certificate);
            TheUnitOfWork.Commit();

            return true;
        }

        public bool DeleteCertificate(int id)
        {
            bool result = false;
            TheUnitOfWork.Certificate.Delete(id);
            result = TheUnitOfWork.Commit() > new int();
            return result;
        }

        public bool CheckCertificateExists(CertificateViewModel certificateViewModel)
        {
            Certificate certificate = Mapper.Map<Certificate>(certificateViewModel);
            return TheUnitOfWork.Certificate.CheckIsCertificateExists(certificate);
        }
    }
}
