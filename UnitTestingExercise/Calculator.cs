﻿using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // Step 1: Add a reference to your UnitTestingExercise project:

        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        // and add your reference to the UnitTestingExercise project        --done


        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer --done
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method  --done

        // Step 4: Create a Subtract method that accepts 2 integers     --done
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        // Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method     --done

        // Step 6: Create a Multiply method that passes 2 integers      --done
        public int Multiply(int multiplicand, int multiplier)
        {
            return multiplicand * multiplier;
        }

        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method    --done

        // Step 8: Create a Divide method that passes 2 integers        --done
        public int Divide(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method       --done


        //*****NOW RUN ALL OF YOUR TESTS*********//     --done
    }
}
