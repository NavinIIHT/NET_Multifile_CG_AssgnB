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
    public class FunctionalTests
    {
        /// <summary>
        /// Creating test output text file that store the result in boolean result
        /// </summary>
        static FunctionalTests()
        {
            if (!File.Exists("../../../../output_revised.txt"))
                try
                {
                    File.Create("../../../../output_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_revised.txt");
                File.Create("../../../../output_revised.txt").Dispose();
            }
        }

        #region Piglatin
        /// <summary>
        /// Test to convert the source string to Piglatin form - result is returned as expected
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestStringToPiglatinForm_ExpectedValue()
        {
            //Arrange
            bool res = false;
            string sourceStr = "techademy", expected = "echademytay";

            PiglatinForm piglatinForm = new PiglatinForm();

            //Act
            string result = piglatinForm.ConvertStringToPiglatin(sourceStr);

            //Assertion
            if (result == expected)
            {
                res = true;
            }
            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestStringToPiglatinForm_ExpectedValue=" + res + "\n");
            return res;
        }
        #endregion

        #region CategorizeCharacters
        /// <summary>
        /// Test to get the different types of characters - result is returned as expected
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestCategorizeCharacters_ExpectedValue()
        {
            //Arrange
            bool res = false;
            string sourceStr = "SampLE23$#";
            int specCharacters = 2, capitalCharacters = 3, lowerChars = 3, numbers = 2, a = 0, b = 0, c = 0, d = 0;
            int diffCharTypes = 4;//

            CategorizeStringCharacters categorizeStringCharacters =
                new CategorizeStringCharacters();

            //Act
            int[] characters = categorizeStringCharacters.CategorizeCharactersFromString(sourceStr);

            if (characters != null)
            {
                a = characters[0];//numbers
                b = characters[1];//lowercase
                c = characters[2];//upperchars
                d = characters[3];//specialchars

                //Assertion
                if (characters.Length == diffCharTypes
                && a == numbers && b == lowerChars
                && capitalCharacters == c && specCharacters == d)
                {
                    res = true;
                }
            }
            else
                res = false;

            //Assert
            //final result displaying in text file
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestCategorizeCharacters_ExpectedValue=" + res + "\n");
            return res;
        }
        #endregion

        #region NumberOfOperations

        /// <summary>
        /// Test to get the count of division Operations on a number to get the 1
        /// </summary>
        /// <returns></returns>
        [Fact]
        public async Task<bool> TestGetCountOfDivisionOperations_ExpectedValue()
        {
            //Arrange
            bool res = false;
            int n = 100, expected = 7;

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
            await File.AppendAllTextAsync("../../../../output_revised.txt", "TestGetCountOfDivisionOperations_ExpectedValue=" + res + "\n");
            return res;
        }

        #endregion
    }
}
