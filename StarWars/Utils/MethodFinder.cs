using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace StarWars.Utils
{
    /// <summary>
    /// https://stackoverflow.com/questions/5152346/get-only-methods-with-specific-signature-out-of-type-getmethods
    /// </summary>
    internal static class MethodFinder
    {
        public static IEnumerable<MethodInfo> GetPublicMethodsBySignature(
            Type type,
            string name,
            Type returnType,
            Type? customAttributeType,
            bool matchParameterInheritence,
            params Type[] parameterTypes)
        {
            return type.GetMethods().Where((methodInfo) =>
            {
                if (!methodInfo.IsPublic)
                {
                    return false;
                }

                if (methodInfo.Name != name)
                {
                    return false;
                }

                if (methodInfo.ReturnType != returnType)
                {
                    return false;
                }

                if (customAttributeType is not null && (methodInfo.GetCustomAttributes(customAttributeType, true).Any() == false))
                {
                    return false;
                }

                var parameters = methodInfo.GetParameters();

                if ((parameterTypes is null || parameterTypes.Length == 0))
                {
                    return parameters.Length == 0;
                }

                if (parameters.Length != parameterTypes.Length)
                {
                    return false;
                }

                for (int i = 0; i < parameterTypes.Length; i++)
                {
                    if (((parameters[i].ParameterType == parameterTypes[i]) || (matchParameterInheritence && parameterTypes[i].IsAssignableFrom(parameters[i].ParameterType))) == false)
                    {
                        return false;
                    }
                }

                return true;
            });
        }

        
        public static IEnumerable<MethodInfo> GetMethodsBySignature1(Type type, Type returnType, params Type[] parameterTypes)
        {
            return type.GetMethods().Where((methodInfo) =>
            {
                if (methodInfo.ReturnType != returnType)
                {
                    return false;
                }

                var parameters = methodInfo.GetParameters();
                if (parameterTypes is null || parameterTypes.Length == 0)
                {
                    return parameters.Length == 0;
                }

                if (parameters.Length != parameterTypes.Length)
                {
                    return false;
                }

                for (int parameterIndex = 0; parameterIndex < parameterTypes.Length; parameterIndex++)
                {
                    if (parameters[parameterIndex].ParameterType != parameterTypes[parameterIndex])
                    {
                        return false;
                    }
                }

                return true;
            });
        }
    }
}