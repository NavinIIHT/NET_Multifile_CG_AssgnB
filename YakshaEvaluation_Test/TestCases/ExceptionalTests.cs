using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Piglatin;
using CategorizeCharacters;
using NumberOperations;

namespace YakshaEvaluation_Test.TestCases
{
    public class ExceptionalTests
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static ExceptionalTests()
        {
            if (!File.Exists("../../../../output_exception_revised.txt"))
                try
                {
                    File.Create("../../../../output_exception_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_exception_revised.txt");
                File.Create("../../../../output_exception_revised.txt").Dispose();
            }
        }

        //categorize - whitespace

        #region Piglatin
        /// <summary>
        /// Test to convert string to PiglatinForm - with NoVowels 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestPiglatin_WithNoVowels()
        {

            //Arrange
            bool res = false;
            string sourceStr = "rythm";
            PiglatinForm obj = new PiglatinForm();

            //Act
            string result = obj.ConvertStringToPiglatin(sourceStr);
            
            //Assertion
            if (result == "-1")
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestPiglatin_WithNoVowels=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to convert string to PiglatinForm - with only special symbols
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestPiglatin_WithSpecialSymbols()
        {
            //Arrange
            bool res = false;
            string sourceStr = "@#$&";
            PiglatinForm obj = new PiglatinForm();

            //Act
            string result = obj.ConvertStringToPiglatin(sourceStr);

            //Assertion
            if (result == "-1")
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestPiglatin_WithSpecialSymbols=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to convert string to PiglatinForm - with Number String
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestPiglatin_WithNumberString()
        {
            //Arrange
            bool res = false;
            string sourceStr = "12345";
            PiglatinForm obj = new PiglatinForm();

            //Act
            string result = obj.ConvertStringToPiglatin(sourceStr);

            //Assertion
            if (result == "-1")
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestPiglatin_WithNumberString=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test To convert source string to Piglatin, for Null value 
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestPiglatin_ForNullValue()
        {
            //Arrange
            bool res = false;

            PiglatinForm piglatinForm = new PiglatinForm();

            //Act
            string result = piglatinForm.ConvertStringToPiglatin(null);

            //Assertion
            if (result == null)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestPiglatin_ForNullValue=" + res + "\n");
            return res;
        }

        #endregion

        #region CategorizeCharacters
        /// <summary>
        /// Test to get the different types of characters - for Null Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestCategorizeCharacters_ForNullValue()
        {
            //Arrange
            bool res = false;

            CategorizeStringCharacters categorizeStringCharacters =
                new CategorizeStringCharacters();

            //Act
            int[] characters = categorizeStringCharacters.CategorizeCharactersFromString(null);

            //Assertion
            if (characters == null)
            {
                res = true;
            }

            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestCategorizeCharacters_ForNullValue=" + res + "\n");
            return res;
        }
        #endregion

        #region NumberOfOperations

        /// <summary>
        /// Test to get the count of division Operations on a number to get 1 - For Zero value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestGetCountOfDivisionOperations_ForZero()
        {
            //Arrange
            bool res = false;
            int n = 0, expected = -1;

            NumberOperation numberOperations = new NumberOperation();

            //Act
            int result = numberOperations.GetCountOfDivisionOperations(n);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestGetCountOfDivisionOperations_ForZero=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to get the count of division Operations on a number to get 1 - For Minus Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestGetCountOfDivisionOperations_ForMinusValue()
        {
            //Arrange
            bool res = false;
            int n = -10, expected = -1;

            NumberOperation numberOperations = new NumberOperation();

            //Act
            int result = numberOperations.GetCountOfDivisionOperations(n);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_exception_revised.txt", "TestGetCountOfDivisionOperations_ForMinusValue=" + res + "\n");
            return res;
        }

        #endregion
    }
}
