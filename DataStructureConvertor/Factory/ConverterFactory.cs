using DataStructureConvertor.Attributes;
using DataStructureConvertor.Core;
using DataStructureConvertor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DataStructureConvertor.Factory
{
    internal static class ConverterFactory
    {
        public static IEnumerable<ChooseItem> GetInputConverterTypes()
        {
            foreach (var type in GetInputConverterTypesImpl())
            {
                var caption = GetCaption(type);

                yield return new ChooseItem(type, caption);
            }
        }

        private static IEnumerable<Type> GetInputConverterTypesImpl()
        {
            return GetAssignableFromTypes(typeof(IConverterInput));
        }

        public static IEnumerable<ChooseItem> GetOutputConverterTypes()
        {
            foreach (var type in GetOutputConverterTypesImpl())
            {
                var caption = GetCaption(type);

                yield return new ChooseItem(type, caption);
            }
        }

        private static IEnumerable<Type> GetOutputConverterTypesImpl()
        {
            return GetAssignableFromTypes(typeof(IConvertorOutput));
        }

        private static IEnumerable<Type> GetAssignableFromTypes(Type type)
        {
            return Assembly.GetEntryAssembly().GetTypes().Where(a => type.IsAssignableFrom(a) && !a.IsInterface && !a.IsAbstract);
        }

        private static string GetCaption(Type type)
        {
            var atr = type.GetCustomAttribute<ConverterCaptionAttribute>();

            return atr == null ? type.ToString() : atr.Caption;
        }

        public static IUiGetterInput CreateGetterInput(Type type)
        {
            var atr = type.GetCustomAttribute<ConverterUIActionTypeAttribute>();

            if (atr == null)
            {
                return null;
            }

            return Activator.CreateInstance(atr.UiGetterType) as IUiGetterInput;
        }

        public static IUiGetterOutput CreateGetterOutput(Type type)
        {
            var atr = type.GetCustomAttribute<ConverterUIActionTypeAttribute>();

            if (atr == null)
            {
                return null;
            }

            return Activator.CreateInstance(atr.UiGetterType) as IUiGetterOutput;
        }

        public static IConverterInput CreateInput(Type type, IUiGetterInput arg)
        {
            return Activator.CreateInstance(type, arg.Text) as IConverterInput;
        }

        public static IConvertorOutput CreateOutput(Type type, IUiGetterOutput arg)
        {
            return Activator.CreateInstance(type, arg.Text) as IConvertorOutput;
        }
    }
}
