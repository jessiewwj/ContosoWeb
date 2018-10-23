﻿using Contoso.Data;
using Contoso.Data.Repositories;
using Contoso.Model.Models;
using System.Collections.Generic;


namespace Contoso.Service
{
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository instructorRepository;
        public InstructorService()
        {

            instructorRepository = new InstructorRepository(new ContosoDbContext());
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            return instructorRepository.GetAll();
        }

        public Instructor GetInstructorById(int Id)
        {
            return instructorRepository.GetById(Id);
        }

        public void CreateInstructor(Instructor instructor)
        {
            instructorRepository.Add(instructor);
        }
        public void UpdateInstructor(Instructor instructor)
        {
            instructorRepository.Update(instructor);
        }
    }

    public interface IInstructorService
    {
        IEnumerable<Instructor> GetAllInstructors();

        Instructor GetInstructorById(int Id);
        void CreateInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);
    }
}
