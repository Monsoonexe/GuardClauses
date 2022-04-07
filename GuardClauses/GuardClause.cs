﻿using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace GuardClauses
{
    public static class GuardClause
    {
        // https://devblogs.microsoft.com/csharpfaq/what-is-the-difference-between-const-and-static-readonly/
        private const string VALID_EMAIL_ADDRESS_PATTERN =
            (@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        //https://regex101.com/r/8M0MqB/1
        //https://stackoverflow.com/questions/6038061/regular-expression-to-find-urls-within-a-string
        private const string VALID_URL_PATTERN =
            @"([\w+]+\:\/\/)?([\w\d-]+\.)*[\w-]+[\.\:]\w+([\/\?\=\&\#.]?[\w-]+)*\/?";
            //@"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&%\$#_]*)?$";
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZero(int argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZero(long argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZero(decimal argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZero(double argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero.");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZero(float argumentValue, string argumentName)
        {
            if (argumentValue == 0)
                throw new ArgumentException($"{argumentName} is zero.");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNegative(int argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNegative(long argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNegative(decimal argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNegative(double argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNegative(float argumentValue, string argumentName)
        {
            if (argumentValue < 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsPositive(int argumentValue, string argumentName)
        {
            if (argumentValue > 0)
                throw new ArgumentException($"{argumentName} is positive number");
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsPositive(long argumentValue, string argumentName)
        {
            if (argumentValue > 0)
                throw new ArgumentException($"{argumentName} is positive number");
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsPositive(decimal argumentValue, string argumentName)
        {
            if (argumentValue > 0)
                throw new ArgumentException($"{argumentName} is positive number");
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsPositive(float argumentValue, string argumentName)
        {
            if (argumentValue > 0)
                throw new ArgumentException($"{argumentName} is positive number");
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsPositive(double argumentValue, string argumentName)
        {
            if (argumentValue > 0)
                throw new ArgumentException($"{argumentName} is positive number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZeroOrNegative(int argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZeroOrNegative(long argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZeroOrNegative(decimal argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZeroOrNegative(double argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsZeroOrNegative(float argumentValue, string argumentName)
        {
            if (argumentValue < 0 || argumentValue == 0)
                throw new ArgumentException($"{argumentName} is 0 or negative number");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsLengthExceeded(string argumentValue, string argumentName, int maximumLength)
        {
            if (argumentValue.Length > maximumLength)
                throw new ArgumentException($"{argumentName} has exceeded maximum number of characters");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNullOrEmptyStringOrWhiteSpace(string argumentValue, string argumentName)
        {
            IsNullOrWhiteSpace(argumentValue, nameof(argumentName));
            IsNullOrEmptyString(argumentValue, nameof(argumentName));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNullOrWhiteSpace(string argumentValue, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argumentValue))
                throw new ArgumentException($"{argumentName} is null or white space");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNullOrEmptyString(string argumentValue, string argumentName)
        {
            if (string.IsNullOrEmpty(argumentValue))
                throw new ArgumentException($"{argumentName} is null or empty string");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ArgumentIsNotNull(object value, string argumentName)
        {
            if (ReferenceEquals(value, null))
                throw new ArgumentNullException($"{argumentName} is null object");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DateTimeIsGraterThan(DateTime argumentValue, string argumentName, DateTime comparableDateTme)
        {
            if (argumentValue > comparableDateTme)
                throw new ArgumentException(
                    $"{nameof(argumentName)}{argumentValue} is greater than {comparableDateTme}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DateTimeIsLessThan(DateTime argumentValue, string argumentName, DateTime comparableDateTme)
        {
            if (argumentValue < comparableDateTme)
                throw new ArgumentException($"{nameof(argumentName)}{argumentValue} is less than {comparableDateTme}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void DateTimeIsOutOfRange(DateTime argumentValue, DateTime startDateTime, string argumentName,
            DateTime endDateTime)
        {
            if (argumentValue < startDateTime || argumentValue > endDateTime)
                throw new ArgumentException($"{nameof(argumentName)} is out of range");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsStringEmptyGuid(string argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty.ToString())
                throw new ArgumentException($"{nameof(argumentName)} can not be string with value of empty guid.");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsEmptyGuid(Guid argumentValue, string argumentName)
        {
            if (argumentValue == Guid.Empty)
                throw new ArgumentException($"{nameof(argumentName)} can not be string with value of empty guid.");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsEmailValid(string email)
        {
            var regex = new Regex(VALID_EMAIL_ADDRESS_PATTERN, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(email))
                throw new ArgumentException($"{email} is not valid");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void UrlChecker(string url)
        {
            var regex = new Regex(VALID_URL_PATTERN);
            if (!regex.IsMatch(url))
                throw new ArgumentException($"{url} is not valid");
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MaximumLength(string argumentValue, string argumentName, int maximumLength)
        {
            if (argumentValue.Length > maximumLength)
                throw new ArgumentException($"Argument {argumentName} exceed maximum length {maximumLength}");
        }
    }
}
