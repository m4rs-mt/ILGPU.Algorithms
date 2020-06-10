using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Numerics;
using ILGPU.Algorithms.Sequencers;
using ILGPU.Runtime;
using ILGPU.Tests;
using Xunit;
using Xunit.Abstractions;

namespace ILGPU.Algorithms.Tests
{
    public interface IVector<T> : IXunitSerializable
        where T : struct
    {
        T GetVector();
    }
    
    public abstract partial class VectorTests : TestBase
    {
        protected VectorTests(ITestOutputHelper output, TestContext testContext)
            : base(output, testContext)
        { }

        #region Xunit Vectors

        #region Vector2

        internal readonly struct Vector2Zero : IVector<Vector2>
        {
            Vector2 IVector<Vector2>.GetVector() => Vector2.Zero;
            public void Deserialize(IXunitSerializationInfo info) { } 
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector2One : IVector<Vector2>
        {
            Vector2 IVector<Vector2>.GetVector() => Vector2.One;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector2UnitX : IVector<Vector2>
        {
            Vector2 IVector<Vector2>.GetVector() => Vector2.UnitX;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector2UnitY : IVector<Vector2>
        {
            Vector2 IVector<Vector2>.GetVector() => Vector2.UnitY;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        #endregion

        #region Vector3

        internal readonly struct Vector3Zero : IVector<Vector3>
        {
            Vector3 IVector<Vector3>.GetVector() => Vector3.Zero;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector3One : IVector<Vector3>
        {
            Vector3 IVector<Vector3>.GetVector() => Vector3.One;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector3UnitX : IVector<Vector3>
        {
            Vector3 IVector<Vector3>.GetVector() => Vector3.UnitX;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector3UnitY : IVector<Vector3>
        {
            Vector3 IVector<Vector3>.GetVector() => Vector3.UnitY;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector3UnitZ : IVector<Vector3>
        {
            Vector3 IVector<Vector3>.GetVector() => Vector3.UnitZ;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        #endregion

        #region Vector4

        internal readonly struct Vector4Zero : IVector<Vector4>
        {
            Vector4 IVector<Vector4>.GetVector() => Vector4.Zero;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector4One : IVector<Vector4>
        {
            Vector4 IVector<Vector4>.GetVector() => Vector4.One;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector4UnitX : IVector<Vector4>
        {
            Vector4 IVector<Vector4>.GetVector() => Vector4.UnitX;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector4UnitY : IVector<Vector4>
        {
            Vector4 IVector<Vector4>.GetVector() => Vector4.UnitY;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector4UnitZ : IVector<Vector4>
        {
            Vector4 IVector<Vector4>.GetVector() => Vector4.UnitZ;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector4UnitW : IVector<Vector4>
        {
            Vector4 IVector<Vector4>.GetVector() => Vector4.UnitW;
            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        #endregion

        #endregion

        #region VectorSequencer

        internal readonly struct Vector2DSequencer : ITestSequencer<Vector2>
        {
            public Vector2[] ComputeSequence(Vector2 start, Vector2 stepSize, int length)
            {
                Vector2[] sequence = new Vector2[length];
                sequence[0] = start;
                for (int i = 1; i < length; ++i)
                    sequence[i] = sequence[i - 1] + stepSize;
                return sequence;
            }

            public Vector2[] ComputeInvertedSequence(Vector2 start, Vector2 stepSize, int length)
            {
                Vector2[] sequence = new Vector2[length];
                sequence[length - 1] = start;
                for (int i = length - 2; i >= 0; --i)
                    sequence[i] = sequence[i + 1] + stepSize;
                return sequence;
            }

            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }

        }

        internal readonly struct Vector3DSequencer : ITestSequencer<Vector3>
        {
            public Vector3[] ComputeSequence(Vector3 start, Vector3 stepSize, int length)
            {
                Vector3[] sequence = new Vector3[length];
                sequence[0] = start;
                for (int i = 1; i < length; ++i)
                    sequence[i] = sequence[i - 1] + stepSize;
                return sequence;
            }

            public Vector3[] ComputeInvertedSequence(Vector3 start, Vector3 stepSize, int length)
            {
                Vector3[] sequence = new Vector3[length];
                sequence[length - 1] = start;
                for (int i = length - 2; i >= 0; --i)
                    sequence[i] = sequence[i + 1] + stepSize;
                return sequence;
            }

            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        internal readonly struct Vector4DSequencer : ITestSequencer<Vector4>
        {
            public Vector4[] ComputeSequence(Vector4 start, Vector4 stepSize, int length)
            {
                Vector4[] sequence = new Vector4[length];
                sequence[0] = start;
                for (int i = 1; i < length; ++i)
                    sequence[i] = sequence[i - 1] + stepSize;
                return sequence;
            }

            public Vector4[] ComputeInvertedSequence(Vector4 start, Vector4 stepSize, int length)
            {
                Vector4[] sequence = new Vector4[length];
                sequence[length - 1] = start;
                for (int i = length - 2; i >= 0; --i)
                    sequence[i] = sequence[i + 1] + stepSize;
                return sequence;
            }

            public void Deserialize(IXunitSerializationInfo info) { }
            public void Serialize(IXunitSerializationInfo info) { }
        }

        #endregion

        #region MemberData

        public static TheoryData<object, object> Vector2dTestData =>
            new TheoryData<object, object>
            {
                { 1, default(Vector2Zero) },
                { 32, default(Vector2One) },
                { 64, default(Vector2UnitX) },
                { 128, default(Vector2UnitY) },
            };

        public static TheoryData<object, object> Vector3dTestData =>
            new TheoryData<object, object>
            {
                { 1, default(Vector3Zero) },
                { 32, default(Vector3One) },
                { 64, default(Vector3UnitX) },
                { 128, default(Vector3UnitY) },
                { 65, default(Vector3UnitZ) },
            };

        public static TheoryData<object, object> Vector4dTestData =>
            new TheoryData<object, object>
            {
                { 1, default(Vector4Zero) },
                { 32, default(Vector4One) },
                { 64, default(Vector4UnitX) },
                { 128, default(Vector4UnitY) },
                { 127, default(Vector4UnitZ) },
                { 48, default(Vector4UnitW) },
            };

        #endregion

        #region Kernels

        internal static void Vector2dAddKernel(
            Index1 index,
            ArrayView<Vector2> input,
            Vector2 operand)
        {
            var target = input.GetVariableView(index);
            target.AtomicAdd(operand);
        }

        internal static void Vector3dAddKernel(
            Index1 index,
            ArrayView<Vector3> input,
            Vector3 operand)
        {
            var target = input.GetVariableView(index);
            target.AtomicAdd(operand);
        }

        internal static void Vector4dAddKernel(
            Index1 index,
            ArrayView<Vector4> input,
            Vector4 operand)
        {
            var target = input.GetVariableView(index);
            target.AtomicAdd(operand);
        }

        #endregion

        [Theory]
        [MemberData(nameof(Vector2dTestData))]
        [KernelMethod(nameof(Vector2dAddKernel))]
        public void Vector2dAdd<TVector>(int size, TVector vector)
            where TVector : struct, IVector<Vector2>
        {
            using var stream = Accelerator.CreateStream();
            using var targetBuffer = Accelerator.Allocate<Vector2>(size);

            var sequencer = new Vector2DSequencer();
            var sequence = sequencer.ComputeSequence(
                new Vector2(0, size - 1),
                new Vector2(1, -1),
                size);
            targetBuffer.CopyFrom(stream, sequence, 0, 0, size);
            stream.Synchronize();
            
            Execute(targetBuffer.Length, targetBuffer.View, vector.GetVector());

            var expected = new Vector2[size];
            for (int i = 0; i < size; ++i)
                expected[i] = new Vector2(i, size - 1 - i) + vector.GetVector();

            Verify(targetBuffer, expected);
        }

        [Theory]
        [MemberData(nameof(Vector3dTestData))]
        [KernelMethod(nameof(Vector3dAddKernel))]
        public void Vector3dAdd<TVector>(int size, TVector vector)
            where TVector : struct, IVector<Vector3>
        {
            using var targetBuffer = Accelerator.Allocate<Vector3>(size);
            using var stream = Accelerator.CreateStream();

            var sequencer = new Vector3DSequencer();
            var sequence = sequencer.ComputeSequence(
                new Vector3(0, size - 1, 0),
                new Vector3(1, -1, 1),
                size);
            targetBuffer.CopyFrom(stream, sequence, 0, 0, size);
            stream.Synchronize();

            Execute(targetBuffer.Length, targetBuffer.View, vector.GetVector());

            var expected = new Vector3[size];
            for (int i = 0; i < size; ++i)
                expected[i] = new Vector3(i, size - 1 - i, i) + vector.GetVector();

            Verify(targetBuffer, expected);
        }

        [Theory]
        [MemberData(nameof(Vector4dTestData))]
        [KernelMethod(nameof(Vector4dAddKernel))]
        public void Vector4dAdd<TVector>(int size, TVector vector)
            where TVector : struct, IVector<Vector4>
        {
            using var targetBuffer = Accelerator.Allocate<Vector4>(size);
            using var stream = Accelerator.CreateStream();

            var sequencer = new Vector4DSequencer();
            var sequence = sequencer.ComputeSequence(
                new Vector4(0, size - 1, 0, 0),
                new Vector4(1, -1, 1, 0),
                size);
            targetBuffer.CopyFrom(stream, sequence, 0, 0, size);
            stream.Synchronize();

            Execute(targetBuffer.Length, targetBuffer.View, vector.GetVector());

            var expected = new Vector4[size];
            for (int i = 0; i < size; ++i)
                expected[i] = new Vector4(i, size - 1 - i, i, 0) + vector.GetVector();

            Verify(targetBuffer, expected);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 2)]
        [InlineData(2, 1)]
        public void Index2Vector2Conv(float x, float y)
        {
            Vector2 initVector = new Vector2(x, y);
            Index2 initIndex = new Index2((int)x, (int)y);

            Index2 index = initVector.ToIndex();
            Vector2 vector = index.ToVector();

            Assert.Equal(initVector, vector);
            Assert.Equal(initIndex, index);
        }

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(1,2,3)]
        [InlineData(3,2,1)]
        public void Index3Vector3Conv(float x, float y, float z)
        {
            Vector3 initVector = new Vector3(x, y, z);
            Index3 initIndex = new Index3((int)x, (int)y, (int)z);

            Index3 index = initVector.ToIndex();
            Vector3 vector = index.ToVector();

            Assert.Equal(initVector, vector);
            Assert.Equal(initIndex, index);
        }
    }
}
