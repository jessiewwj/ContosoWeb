﻿using Contoso.Model.Models;
using System.Collections.Generic;
using Contoso.Data.Repositories;
using Contoso.Data;


namespace Contoso.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        public DepartmentService()
        {
            departmentRepository = new DepartmentRepository(new ContosoDbContext());
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return departmentRepository.GetAll();
        }

        public Department GetDepartmentById(int Id)
        {
            return departmentRepository.GetById(Id);
        }

        public void CreateDepartment(Department department)
        {
            departmentRepository.Add(department);
            departmentRepository.SaveChanges();

        }
        public void UpdateDepartment(Department department)
        {
            departmentRepository.Update(department);
            departmentRepository.SaveChanges(); 
        }
    }

    public class DepartmentTestService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        public DepartmentTestService()
        {
            departmentRepository = new DepartmentRepository(new ContosoDbContext());
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return departmentRepository.GetAll();
        }

        public Department GetDepartmentById(int Id)
        {
            return departmentRepository.GetById(Id);
        }

        public void CreateDepartment(Department department)
        {
            departmentRepository.Add(department);
            departmentRepository.SaveChanges();

        }
        public void UpdateDepartment(Department department)
        {
            departmentRepository.Update(department);
            departmentRepository.SaveChanges();
        }
    }

    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartments();

        Department GetDepartmentById(int Id);
        void CreateDepartment(Department department);
        void UpdateDepartment(Department department);
    }
}

