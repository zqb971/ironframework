//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
// DTO 模型与数据层的实体 相互 转换工具 类
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessObject.Util
{
    using System;using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;using Newtonsoft.Json;
     using DataTransferObject.Model;using BusinessEntities;
     using DataTransferObject;
    using System.Collections.Generic;
    
    public interface IEmployeeConverter
        {
            Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto);
            Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto, Employee efEmployee);
            Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto,bool skipNullPropertyValue);
            Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto, Employee efEmployee, bool skipNullPropertyValue);
            EmployeeDto ConvertEntitiesToDto(Employee _Employee);
         }
    public partial class EmployeeConverter: IEmployeeConverter
    {
           /// <summary>
           /// Converts the dto to entities.
           /// </summary>
           /// <param name="_EmployeeDto">The Employee dto.</param>
           /// <returns>Employee</returns>
           public Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto)
           {
              if (_EmployeeDto==null)
              {
                  throw new ArgumentNullException("model should not be null");
              }
              var efEmployee=new Employee();
              ConvertObject(_EmployeeDto, efEmployee);
              return efEmployee;
           }
    
              /// <summary>
              /// Converts the dto to entities.
              /// </summary>
              /// <param name="_EmployeeDto">The Employee dto</param>
              /// <param name="efEmployee">已存在的Employee EF model</param>
              /// <returns>Employee</returns>
             public Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto, Employee efEmployee)
             {
                  if (_EmployeeDto==null && efEmployee==null)
                  {
                       throw new ArgumentNullException("models should not be null");
                  }
                   ConvertObject(_EmployeeDto, efEmployee);
                   return efEmployee;
             }
    
           /// <summary>
           /// Converts the dto to entities.
           /// </summary>
           /// <param name="_EmployeeDto">The Employee dto.</param>
           /// <param name="skipNullPropertyValue">if set to <c>true</c> [skip null property value].</param>
          /// <returns>Employee</returns>
         public Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto,bool skipNullPropertyValue)
        {
              if (_EmployeeDto==null)
              {
                  throw new ArgumentNullException("model should not be null");
              }
    
             var efEmployee=new Employee();
    
             ConvertObjectWithCheckNull(_EmployeeDto, skipNullPropertyValue, efEmployee);
             return efEmployee;
         }
    
             /// <summary>
             /// Converts the dto to entities.
             /// </summary>
             /// <param name="_ EmployeeDto">The  Employee dto.</param>
             /// <param name="ef Employee">已存的EntityFramework实体 ef Employee</param>
             /// <param name="skipNullPropertyValue">if set to <c>true</c> [skip null property value].</param>
             /// <returns>Employee</returns>
           public Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto, Employee efEmployee, bool skipNullPropertyValue)
           {
                  if (_EmployeeDto==null && efEmployee==null)
                  {
                       throw new ArgumentNullException("models should not be null");
                  }
    
                 ConvertObjectWithCheckNull(_EmployeeDto, skipNullPropertyValue, efEmployee);
                 return efEmployee;
           }
    
          private static void ConvertObjectWithCheckNull(EmployeeDto _EmployeeDto, bool skipNullPropertyValue, Employee efEmployee)
          {
               efEmployee.EmployeeID=_EmployeeDto.EmployeeID;
          
               if (!skipNullPropertyValue ||  _EmployeeDto.NationalIDNumber != null) {efEmployee.NationalIDNumber=_EmployeeDto.NationalIDNumber; }
                  efEmployee.ContactID=_EmployeeDto.ContactID;
          
               if (!skipNullPropertyValue ||  _EmployeeDto.LoginID != null) {efEmployee.LoginID=_EmployeeDto.LoginID; }
                  efEmployee.ManagerID=_EmployeeDto.ManagerID;
          
               if (!skipNullPropertyValue ||  _EmployeeDto.Title != null) {efEmployee.Title=_EmployeeDto.Title; }
                  efEmployee.BirthDate=_EmployeeDto.BirthDate;
          
               if (!skipNullPropertyValue ||  _EmployeeDto.MaritalStatus != null) {efEmployee.MaritalStatus=_EmployeeDto.MaritalStatus; }
        
               if (!skipNullPropertyValue ||  _EmployeeDto.Gender != null) {efEmployee.Gender=_EmployeeDto.Gender; }
                  efEmployee.HireDate=_EmployeeDto.HireDate;
                    efEmployee.SalariedFlag=_EmployeeDto.SalariedFlag;
                    efEmployee.VacationHours=_EmployeeDto.VacationHours;
                    efEmployee.SickLeaveHours=_EmployeeDto.SickLeaveHours;
                    efEmployee.CurrentFlag=_EmployeeDto.CurrentFlag;
                    efEmployee.rowguid=_EmployeeDto.rowguid;
                    efEmployee.ModifiedDate=_EmployeeDto.ModifiedDate;
         
            }
    
           /// <summary>
           /// Converts the entities to dto.
          /// </summary>
          /// <param name="_Employee">The Employee entity</param>
          /// <returns>EmployeeDto</returns>
         public EmployeeDto ConvertEntitiesToDto(Employee  _Employee)
        {
              if (_Employee==null)
              {
                       throw new ArgumentNullException("models should not be null");
              }
    
             var _EmployeeDto =new EmployeeDto();
                         _EmployeeDto.EmployeeID=_Employee.EmployeeID; 
                  _EmployeeDto.NationalIDNumber=_Employee.NationalIDNumber; 
                  _EmployeeDto.ContactID=_Employee.ContactID; 
                  _EmployeeDto.LoginID=_Employee.LoginID; 
                  _EmployeeDto.ManagerID=_Employee.ManagerID; 
                  _EmployeeDto.Title=_Employee.Title; 
                  _EmployeeDto.BirthDate=_Employee.BirthDate; 
                  _EmployeeDto.MaritalStatus=_Employee.MaritalStatus; 
                  _EmployeeDto.Gender=_Employee.Gender; 
                  _EmployeeDto.HireDate=_Employee.HireDate; 
                  _EmployeeDto.SalariedFlag=_Employee.SalariedFlag; 
                  _EmployeeDto.VacationHours=_Employee.VacationHours; 
                  _EmployeeDto.SickLeaveHours=_Employee.SickLeaveHours; 
                  _EmployeeDto.CurrentFlag=_Employee.CurrentFlag; 
                  _EmployeeDto.rowguid=_Employee.rowguid; 
                  _EmployeeDto.ModifiedDate=_Employee.ModifiedDate; 
                 return _EmployeeDto;
        }
    
           private static void ConvertObject(EmployeeDto _EmployeeDto, Employee efEmployee)
           {
               efEmployee.EmployeeID=_EmployeeDto.EmployeeID; 
                  efEmployee.NationalIDNumber=_EmployeeDto.NationalIDNumber; 
                  efEmployee.ContactID=_EmployeeDto.ContactID; 
                  efEmployee.LoginID=_EmployeeDto.LoginID; 
                  efEmployee.ManagerID=_EmployeeDto.ManagerID; 
                  efEmployee.Title=_EmployeeDto.Title; 
                  efEmployee.BirthDate=_EmployeeDto.BirthDate; 
                  efEmployee.MaritalStatus=_EmployeeDto.MaritalStatus; 
                  efEmployee.Gender=_EmployeeDto.Gender; 
                  efEmployee.HireDate=_EmployeeDto.HireDate; 
                  efEmployee.SalariedFlag=_EmployeeDto.SalariedFlag; 
                  efEmployee.VacationHours=_EmployeeDto.VacationHours; 
                  efEmployee.SickLeaveHours=_EmployeeDto.SickLeaveHours; 
                  efEmployee.CurrentFlag=_EmployeeDto.CurrentFlag; 
                  efEmployee.rowguid=_EmployeeDto.rowguid; 
                  efEmployee.ModifiedDate=_EmployeeDto.ModifiedDate; 
              }
    
        //public virtual ContactDto Contacts { get; set; }
        //public virtual EmployeeDto [] Employee1s { get; set; }
        //public virtual EmployeeDto Employee2s { get; set; }
        //public virtual EmployeePayHistoryDto [] EmployeePayHistoriess { get; set; }
    }
           public class FakeEmployeeConverter:IEmployeeConverter
           {
    
            public Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto)
            {
                return new Employee();
            }
    
            public Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto, Employee efEmployee)
            {
                return new Employee();
            }
    
            public Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto, bool skipNullPropertyValue)
            {
                return new Employee();
            }
    
            public Employee ConvertDtoToEntities(EmployeeDto _EmployeeDto, Employee efEmployee, bool skipNullPropertyValue)
            {
                return new Employee();
            }
    
            public EmployeeDto ConvertEntitiesToDto(Employee _Employee)
            {
                return new EmployeeDto();
            }
          }
}
