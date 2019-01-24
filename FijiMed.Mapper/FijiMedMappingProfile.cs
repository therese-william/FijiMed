using AutoMapper;
using FijiMed.Data.Entities;
using FijiMed.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FijiMed.Mapper
{
	public class FijiMedMappingProfile : Profile
	{
		public FijiMedMappingProfile()
		{
			CreateMap<Doctor, DoctorViewModel>()
				.ForMember(vm => vm.FullName, ex => ex.MapFrom(d => d.DoctorUser.FirstName + " " + d.DoctorUser.LastName))
				.ReverseMap();
			CreateMap<Script, ScriptViewModel>().ReverseMap();
		}
	}
}
