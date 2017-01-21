# Math/Physics Engine

## Introduction
This project does not create a fully functional Math/Physics engine for game programming. This project is a teaching tool for students enrolled in PHYS1521, in the DMIT program, at NAIT. Students enrolled in PHYS1521 will make changes and modifications to their copy of this engine as part of their course lab work.

## How to use?
1. Create your own [GitHub](https://github.com) account.
2. Request a student discount from [GitHub Education](https://education.github.com/).
3. Install and setup GitHub Desktop.
4. Once logged in to your GitHub account using GitHub Desktop, click the **+** symbol (upper left corner) and click the **Create** tab.
5. Give the repository a namne, i.e. MathPhysicsEngine, and accept the default location.
6. Add a Git ignore for Visual Studio (select from the drop down list).
7. **Create repository**.
8. Once created, tight-click the repository and **Open in Explorer**. You will see a folder containig two files `.gitattributes` and `.gitignore`, which were created automatically.
9. Download the ZIP file from [GitHub](https://github.com/bandit412/MathPhysicsEngine). Extract the **PHYS1521_MathPhysicsEngine** folder and copy to the folder from step 8 above.
10. Return to GitHub Desktop and you will see a _bullet_ beside the **Changes** tab. Select the **Changes** tab and you should see a list of files added from step 9 above.
11. Commit your changes by adding a **Summary** message, i.e. Created my copy of the MathPhysicsEngine, and an optioonal **Descroiption**. Once this is done you will be able to **Commit** your changes. _The **Commit** only stages your changes, gets them ready for submission to GitHub_.
12. Once you have committed your changes you can press the **Publish** button. If you already have a confirmation from GitHub Education, you can make this new repository **Private**, otherwise leave as **Public** (you can change it to **Private** at a later date through the repositories settings).
13. Next you will need to add your instructor as a **Collaborator** for your project. As a collaborator, your instructor only needs to see your code for evaluation purposes.
14. You should create a branch for each lab to seperate your work and alwyas have some good code.

## Sample Code
Some sample code is provided in the initial project solution. The `Eng_Point2D` class is defined as:

```csharp
namespace Engine.Classes
{
    public class Eng_Point2D
    {
        public double x { get; set; }
        public double y { get; set; }

        public Eng_Point2D() { }
        public Eng_Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
```

In the `Calculator.cs` class file there is some sample methods:
```csharp
namespace Engine
{
    public class Calculator
    {
        public static double SegmentLength(Eng_Point2D a, Eng_Point2D b)
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }

        public static Eng_Point2D MidPoint(Eng_Point2D a, Eng_Point2D b)
        {
            return new Eng_Point2D(0.5 * (a.x + b.x), 0.5 * (a.y + b.y));
        }
    }
}
```

To test the sample methods there is a test project, `Engine.Specs`, that is set up to have your code automatically tested. The test class, called **EngineTester.cs** has the following code:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Classes;
using Xunit;

namespace Engine.Specs
{
    public class EngineTester
    {
        #region Test Segment Length
        [Theory]
        // Instructor Data
        [InlineData(0, 0, 3, 4, 5)]
        // Student Data
        [InlineData(-1, -1, 2, 3, 5)]
        public void TestSegmentLength(double aX, double aY, double bX, double bY, double expected)
        {
            // Arrange - get data to do the test
            Eng_Point2D givenA = new Eng_Point2D(aX, aY);
            Eng_Point2D givenB = new Eng_Point2D(bX, bY);
            // Act - performing the action
            var actual = Calculator.SegmentLength(givenA, givenB);
            // Assert - did we get back the correct answer
            Assert.Equal(expected, actual);
        }
        #endregion

        #region Test MidPoint
        // Static method to set up Object-based test data
        public static IEnumerable<Object[]> MidPointData()
        {
            // Instructor Data
            // 1st new Eng_Point2D is the point A
            // 2nd new Eng_Point2D is the point B
            // 3rd new Eng_Point2D is the expected outcome
            yield return new Object[]
            {
                new Eng_Point2D(3, 4),
                new Eng_Point2D(6, 9),
                new Eng_Point2D(4.5, 6.5)
            };

            // Student Data
            // 1st new Eng_Point2D is the point A
            // 2nd new Eng_Point2D is the point B
            // 3rd new Eng_Point2D is student expected outcome
            yield return new Object[]
            {
                new Eng_Point2D(3, 4),
                new Eng_Point2D(6, 9),
                new Eng_Point2D(4.5, 5.5)
            };
        }

        [Theory]
        [MemberData("MidPointData")]
        public void TestMidPoint(Eng_Point2D givenA, Eng_Point2D givenB, Eng_Point2D expected)
        {
            // Arrange - get data to do the test
            // This test uses [MemberData]
            // Act - performing the action
            Eng_Point2D actual = Calculator.MidPoint(givenA, givenB);
            // Assert - did we get back the correct answer
            Assert.Equal(expected.x, actual.x);
            Assert.Equal(expected.y, actual.y);
        }
        #endregion
    }
}
```

To run a test first stat the Test Explorer (this will cause your solution to do a Build):

![Test Explorer](TestExplorer.png)

In the initial code selecting **Run All** yeields the following result:

![Test Explorer Output](TestExplorerOutput.png)

The failed test was selected to show what was expected and what was returned by the method. This should aid you in debugging your methods.

**NOTE**:
There are areas setup as Instuctor Data. DO NOT change this data, only add your Student Data to the appropriate areas of the code.

## Testing Hints
### Tuple's
Some of the labs require you to create and return a `Tuple<double, double>`. To test the return of a Tuple:

```csharp
Tuple<double, double> actual = Calculator.SomeMethodName(param1, param2);
// Assert - did we get back the correct answer rounded to 4 decimal places
Assert.Equal(tupleValue1, Math.Round(actual.Item1, 4));
Assert.Equal(tupleValue2, Math.Round(actual.Item2, 4));
```

### Playlists
Once you create all the xunit tests for a lab you can create a playlist. To do this simply select all the tests in the Test Explorer you want to add to your playlist.

![Create New Playlist](xunit_create_playlist.png)

You will then be prompted to name and save your playlist. It is recommended that you save your playlist at the root of your repository for ease of locating and for backup purposes. Once your playlist has been created you can select your playlist and run just those tests.

![Select Playlist](select_playlist.png)

## Student's Responsibilities!
It is each student's responsibility to maintain the code integrity of their individual work. To do this each student's repository on GitHub will be in a private repository. Students **must** add their instructor as a [collaborator](https://help.github.com/articles/inviting-collaborators-to-a-personal-repository/) to thier repository for grading purposes.

## Backups
There is no need to _backup_ your code to a USB device, as GitHub  will be your backup; you can either:

* access your files via [GitHub](http://github.com) or
* install [GitHub Desktop](https://desktop.github.com) to access your repository

## Author
Name: Allan Anderson  
Phone: 780.378.5275  
Email: aanderson@nait.ca
