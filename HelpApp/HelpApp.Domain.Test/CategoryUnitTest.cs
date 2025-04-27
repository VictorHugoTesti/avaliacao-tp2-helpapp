using HelpApp.Domain.Entities;
using HelpApp.Domain.Validation;
using FluentAssertions;
using Xunit;

namespace HelpApp.Domain.Test
{
    public class CategoryUnitTest
    {
        #region Testes Positivos
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Theory(DisplayName = "Should throw exception when creating category with null or empty name")]
        [InlineData(null)]
        [InlineData("")]
        public void CreateCategory_WithNullOrEmptyName_ShouldThrowException(string? name)
        {
            Action action = () => new Category(name!);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Should create a valid category with id and name")]
        public void CreateCategory_WhithValidParameters_ShouldCreateObject()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Should create a valid category whit name only and default id")]
        public void CreateCategory_WhithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
            action.Should().NotThrow<DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Should create a valid category with id and name")]
        public void CreateCategory_WhithOnlyName_ShouldSetDefaultId()
        {
            Action action = () => new Category("Category Name");
            action.Should().NotThrow<HelpApp.Domain.Validation.DomainExceptionValidation>();
        }
        #endregion

        #region Testes Negativos
        [Fact(DisplayName ="Create Category With Name Empty")]
        public void CreateCategory_WithNameEmpty_ResultObjetcException()
        {
            Action action = () => new Category(1, "");
            action.Should().Throw<HelpApp.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Theory(DisplayName = "Should throw exception when creating category with name shorter than 3 characters")]
        [InlineData("A")]
        [InlineData("AB")]
        public void CreateCategory_WithShortName_ShouldThrowException(string name)
        {
            Action action = () => new Category(name);
            action.Should().Throw<DomainExceptionValidation>().WithMessage("Invalid name, too short, minimum 3 characters.");
        }
        #endregion
    }
}
