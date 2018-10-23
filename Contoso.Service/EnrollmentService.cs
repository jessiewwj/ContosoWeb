using Contoso.Model.Models;
using System.Collections.Generic;
using Contoso.Data.Repositories;
using Contoso.Data;


namespace Contoso.Service
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository enrollmentRepository;
        public EnrollmentService()
        {
            enrollmentRepository = new EnrollmentRepository(new ContosoDbContext());
        }

        public IEnumerable<Enrollment> GetAllEnrollments()
        {
            return enrollmentRepository.GetAll();
        }

        public Enrollment GetEnrollmentById(int Id)
        {
            return enrollmentRepository.GetById(Id);
        }

        public void CreateEnrollment(Enrollment enrollment)
        {
            enrollmentRepository.Add(enrollment);
            enrollmentRepository.SaveChanges();

        }
        public void UpdateEnrollment(Enrollment enrollment)
        {
            enrollmentRepository.Update(enrollment);
            enrollmentRepository.SaveChanges();
        }
    }

    public interface IEnrollmentService
    {
        IEnumerable<Enrollment> GetAllEnrollments();

        Enrollment GetEnrollmentById(int Id);
        void CreateEnrollment(Enrollment enrollment);
        void UpdateEnrollment(Enrollment enrollment);
    }
}
