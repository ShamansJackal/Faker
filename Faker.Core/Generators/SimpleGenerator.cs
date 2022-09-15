using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Core.Generators
{
    internal abstract class SimpleGenerator
    {

        public static IReadOnlyDictionary<Type, Func<object>> SimpleGenerators => simpleGenerators;
        protected readonly static Dictionary<Type, Func<object>> simpleGenerators = new();
        protected readonly static Random _random = new(1);

        static SimpleGenerator()
        {
            InitAll();
        }

        protected static byte[] GetBytes(int length)
        {
            byte[] bytes = new byte[length];
            _random.NextBytes(bytes);
            return bytes;
        }

        private static void InitAll() {
            var subClasses = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.IsAssignableTo(typeof(SimpleGenerator)) && x != typeof(SimpleGenerator));
            foreach (var subClass in subClasses) RuntimeHelpers.RunClassConstructor(subClass.TypeHandle);
        }
    }
}
