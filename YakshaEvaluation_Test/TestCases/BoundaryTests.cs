using CategorizeCharacters;
using NumberOperations;
using Piglatin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace YakshaEvaluation_Test.TestCases
{
    public class BoundaryTests
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static BoundaryTests()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }

        #region Piglatin
        /// <summary>
        /// Test To convert source string to Piglatin, for All Vowels In string
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestPiglatin_AllVowels()
        {
            //Arrange
            bool res = false;
            string sourceStr = "AEIOU";

            PiglatinForm piglatinForm = new PiglatinForm();

            //Act
            string result = piglatinForm.ConvertStringToPiglatin(sourceStr);

            //Assertion
            if (result == "AEIOUay")
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestPiglatin_AllVowels=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test To convert source string to Piglatin, for No Vowels In string
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestPiglatin_NoVowels()
        {
            //Arrange
            bool res = false;
            string sourceStr = "rythm";

            PiglatinForm piglatinForm = new PiglatinForm();

            //Act
            string result = piglatinForm.ConvertStringToPiglatin(sourceStr);

            //Assertion
            if (result == "-1")
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestPiglatin_NoVowels=" + res + "\n");
            return res;
        }

        #endregion

        #region CategorizeCharacters
        /// <summary>
        /// Test to get the different types of characters - for No Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestCategorizeCharacters_ForNoValue()
        {
            //Arrange
            bool res = false;

            CategorizeStringCharacters categorizeStringCharacters =
                new CategorizeStringCharacters();

            //Act
            int[] characters = categorizeStringCharacters.CategorizeCharactersFromString("");

            //Assertion
            if (characters == null)
            {
                res = true;
            }

            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestCategorizeCharacters_ForNoValue=" + res + "\n");
            return res;
        }
        #endregion

        #region NumberOfOperations

        /// <summary>
        /// Test to get the count of division Operations on a number to get 1- For Minimal Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestGetCountOfDivisionOperations_ForMinimal()
        {
            //Arrange
            bool res = false;
            int n = 1, expected = 1;

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
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestGetCountOfDivisionOperations_ForMinimal=" + res + "\n");
            return res;
        }

        /// <summary>
        /// Test to get the count of division Operations on a number to get 1 - For Maximum Value
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestGetCountOfDivisionOperations_ForMaximum()
        {
            //Arrange
            bool res = false;
            int n = 100000, expected = 17;

            NumberOperations.NumberOperation numberOperations = new NumberOperations.NumberOperation();

            //Act
            int result = numberOperations.GetCountOfDivisionOperations(n);

            //Assertion
            if (result == expected)
            {
                res = true;
            }

            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_boundary_revised.txt", "TestGetCountOfDivisionOperations_ForMaximum=" + res + "\n");
            return res;
        }

        #endregion
    }
}
