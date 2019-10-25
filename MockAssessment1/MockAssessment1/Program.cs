using System;

namespace MockAssessment1
{
    class Program
    {
        public static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            return false;
        }

        public static double Subtract(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        public static string FindBuildingType(int someKindOfInteger)
        {
            string result = "";
            if (someKindOfInteger >= 4 && someKindOfInteger <= 10)
            {
                result = "This is an office building!";
            }
            else if (someKindOfInteger >= 50)
            {
                result = "This is a SUPER skyscraper!";
            }
            else if (someKindOfInteger >= 11 && someKindOfInteger <= 49)
            {
                result = "This is a skyscraper!";
            }
            else if (someKindOfInteger <= 3)
            {
                result = "This is a house!";
            }
            else
            {
                result =  "You done messed up son";
            }
            return result;
        }









        // In order to run the unit tests provided in this project you will need to down a few NuGet Packages.
        // 1. Select Tools - from the Menu Bar
        //   a. NuGet Package Manager
        //   b. Manage NuGet Packages for solution...
        //
        // 2. In here you will select the BROWSE tab.
        //   a. Search for xunit
        //   b. install xunit (this should be a 50.8M file).
        //   c. On the right-hand side you will see the project MockAssessment2a. Check this box and 
        //      hit install.
        //
        // 3. Search for xunit.runner.visualstudios ( this should be 42.1M file ).
        //   a. install. Click "I Accept" to any prompts that pop up.
        //
        // 4. Select Extensions - from the Menu Bar (look up! ;) )
        //   a. Manage Extensions
        //   b. Navigate to "Online" on the left of the window.
        //   c. Search for xUnit.net.TestGenerator in the upper right search bar in the window.
        //   d. Select xUnit.net.TestGenerator and download.
        //   e. This will require you to restart Visual Studios to install!!
        //   f. A pop-up window will appear asking if you want to Modify Visual Studios - click Modify.
        //
        // 5. Select Build - from the Menu Bar above! Look up! ;)
        //   a. Clean Solution
        //   b. Build Solution
        //
        //#####################################################################
        //#                        RUNNING THE TESTS!!                        #
        //# 1. To run the tests select Test from the Menu Bar above! Look Up! #
        //#   a. Test Explorer                               #
        //# 2. Click on Run All in the test explorer window that pops up.     #
        //# 3. See your results!                                              #
        //#####################################################################
        //}
    }
}
