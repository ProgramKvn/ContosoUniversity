using AutoMapper;
using ContosoUniversity.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.DTOs
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<StudentDTO, Student>();
            CreateMap<Student, StudentDTO>();

        }
    }
}
