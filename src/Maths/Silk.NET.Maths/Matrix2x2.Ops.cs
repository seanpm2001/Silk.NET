﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.Maths
{
    /// <summary>
    /// Methods for working with <see cref="Matrix2x2{T}"/>
    /// </summary>
    public static class Matrix2x2
    {
        /// <summary>Adds two matrices together.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The resulting matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2x2<T> Add<T>(Matrix2x2<T> value1, Matrix2x2<T> value2) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            return value1 + value2;
        }

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2x2<T> Multiply<T>(Matrix2x2<T> value1, Matrix2x2<T> value2) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T> => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix3x2<T> Multiply<T>(Matrix3x2<T> value1, Matrix2x2<T> value2) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T> => value1 * value2;

        /// <summary>Multiplies a matrix by another matrix.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2x3<T> Multiply<T>(Matrix2x2<T> value1, Matrix2x3<T> value2) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T> => value1 * value2;

        /// <summary>Multiplies a matrix by a scalar value.</summary>
        /// <param name="value1">The source matrix.</param>
        /// <param name="value2">The scaling factor.</param>
        /// <returns>The scaled matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2x2<T> Multiply<T>(Matrix2x2<T> value1, T value2) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T> => value1 * value2;

        /// <summary>Multiplies a vector by a matrix.</summary>
        /// <param name="value1">The vector.</param>
        /// <param name="value2">The matrix.</param>
        /// <returns>The result of the multiplication.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Vector2<T> Multiply<T>(Vector2<T> value1, Matrix2x2<T> value2) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T> => value1 * value2;

        /// <summary>Returns a new matrix with the negated elements of the given matrix.</summary>
        /// <param name="value">The source matrix.</param>
        /// <returns>The negated matrix.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2x2<T> Negate<T>(Matrix2x2<T> value) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T> => -value;

        /// <summary>Subtracts the second matrix from the first.</summary>
        /// <param name="value1">The first source matrix.</param>
        /// <param name="value2">The second source matrix.</param>
        /// <returns>The result of the subtraction.</returns>
        [MethodImpl((MethodImplOptions) 768)]
        public static Matrix2x2<T> Subtract<T>(Matrix2x2<T> value1, Matrix2x2<T> value2) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T> => value1 - value2;


        /// <summary>Linearly interpolates between the corresponding values of two matrices.</summary>
        /// <param name="matrix1">The first source matrix.</param>
        /// <param name="matrix2">The second source matrix.</param>
        /// <param name="amount">The relative weight of the second source matrix.</param>
        /// <returns>The interpolated matrix.</returns>
        public static unsafe Matrix2x2<T> Lerp<T>(Matrix2x2<T> matrix1, Matrix2x2<T> matrix2, T amount) where T : unmanaged, IFormattable, IEquatable<T>, IComparable<T>
        {
            Matrix2x2<T> result = default;

            // First row
            result.M11 = Scalar.Add(matrix1.M11, Scalar.Multiply(Scalar.Subtract(matrix2.M11, matrix1.M11), amount));
            result.M12 = Scalar.Add(matrix1.M12, Scalar.Multiply(Scalar.Subtract(matrix2.M12, matrix1.M12), amount));

            // Second row
            result.M21 = Scalar.Add(matrix1.M21, Scalar.Multiply(Scalar.Subtract(matrix2.M21, matrix1.M21), amount));
            result.M22 = Scalar.Add(matrix1.M22, Scalar.Multiply(Scalar.Subtract(matrix2.M22, matrix1.M22), amount));

            return result;
        }
    }
}