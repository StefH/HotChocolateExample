using System;
using System.Reflection;
using HotChocolate.Types;
using HotChocolate.Types.Descriptors;

namespace StarWars.Characters
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method, AllowMultiple = false)]
    public sealed class UseConvertUnitAttribute : DescriptorAttribute
    {
        protected override void TryConfigure(
            IDescriptorContext context,
            IDescriptor descriptor,
            ICustomAttributeProvider element)
        {
            switch (descriptor)
            {
                case IObjectFieldDescriptor objectField:
                    objectField
                        .Argument("unit", a => a.Type<EnumType<Unit>>().DefaultValue(Unit.Meters))
                        .Use(next => async ctx =>
                        {
                            await next(ctx).ConfigureAwait(false);

                            if (ctx.Result is double length)
                            {
                                ctx.Result = ConvertToUnit(length, ctx.ArgumentValue<Unit>("unit"));
                            }
                        });
                    break;

                case IInterfaceFieldDescriptor interfaceField:
                    interfaceField
                        .Argument("unit", a => a.Type<EnumType<Unit>>().DefaultValue(Unit.Meters));
                    break;
            }
        }

        private static double ConvertToUnit(double length, Unit unit)
        {
            if (unit == Unit.Foot)
            {
                return length * 3.28084d;
            }

            return length;
        }
    }
}