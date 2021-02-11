using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApp
{
    public class ComplexNumber
    {
        private double real;
        private double imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public double Real { get => real; }
        public double Imaginary { get => imaginary; }

        public ComplexNumber Add(ComplexNumber number)
        {
            return new ComplexNumber(real + number.Real, imaginary + number.Imaginary);
        }

        //public static ComplexNumber operator +(ComplexNumber number1, ComplexNumber number2)
        //{
        //    return new ComplexNumber(number1.Real + number2.Real, number1.Imaginary + number2.Imaginary);
        //}

        public override string ToString()
        {
            return $"{real}+{imaginary}i";
        }

    }
}
