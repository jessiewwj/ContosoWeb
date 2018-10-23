using Contoso.Model.Models;
using System.Collections.Generic;
using Contoso.Data.Repositories;
using Contoso.Data;


namespace Contoso.Service
{
    public class OfficeAssignmentService : IOfficeAssignmentService
    {
        private readonly IOfficeAssignmentRepository officeAssignmentRepository;
        public OfficeAssignmentService()
        {
            officeAssignmentRepository = new OfficeAssignmentRepository(new ContosoDbContext());
        }

        public IEnumerable<OfficeAssignment> GetAllOfficeAssignments()
        {
            return officeAssignmentRepository.GetAll();
        }

        public OfficeAssignment GetOfficeAssignmentById(int Id)
        {
            return officeAssignmentRepository.GetById(Id);
        }

        public void CreateOfficeAssignment(OfficeAssignment officeAssignment)
        {
            officeAssignmentRepository.Add(officeAssignment);
            officeAssignmentRepository.SaveChanges();

        }
        public void UpdateOfficeAssignment(OfficeAssignment officeAssignment)
        {
            officeAssignmentRepository.Update(officeAssignment);
            officeAssignmentRepository.SaveChanges();
        }
    }

    public interface IOfficeAssignmentService
    {
        IEnumerable<OfficeAssignment> GetAllOfficeAssignments();

        OfficeAssignment GetOfficeAssignmentById(int Id);
        void CreateOfficeAssignment(OfficeAssignment officeAssignment);
        void UpdateOfficeAssignment(OfficeAssignment officeAssignment);
    }
}
