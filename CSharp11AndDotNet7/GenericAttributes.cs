using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11AndDotNet7
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MyAttribute<T> : Attribute
    {
      
    }

    internal class GenericAttributes
    {
        [My<string>]
        public void testM(string param2)
        {

        }
    }

    public class ValidationAttribute<TValidator> : Attribute where TValidator : IValidator
    {
        public Type ValidatorType { get; set; }

        public ValidationAttribute()
        {

            ValidatorType = typeof(TValidator);
        }
    }

    public interface IValidator
    {
    }

    [Validation<UserValidator>]
    public class User
    {

    }

    internal class UserValidator : IValidator
    {
    }
}
