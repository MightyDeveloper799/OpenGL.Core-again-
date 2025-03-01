using System.Runtime.InteropServices;

namespace OpenGL.Core.GL13
{
    public class GL13
    {
        public enum GLenum : uint { }
        public enum GLboolean : byte { }
        public struct GLbitfield { public uint Value; }
        public class GLvoid { }
        public struct GLbyte { public sbyte Value; }
        public struct GLshort { public short Value; }
        public struct GLint { public int Value; }
        public struct GLubyte { public byte Value; }
        public struct GLushort { public ushort Value; }
        public struct GLuint { public uint Value; }
        public struct GLsizei { public int Value; }
        public struct GLfloat { public float Value; }
        public struct GLclampf { public float Value; }
        public struct GLdouble { public double Value; }
        public struct GLclampd { public double Value; }

        /* Multitexture */
        public const int GL_TEXTURE0 = 0x84C0;
        public const int GL_TEXTURE1 = 0x84C1;
        public const int GL_TEXTURE2 = 0x84C2;
        public const int GL_TEXTURE3 = 0x84C3;
        public const int GL_TEXTURE4 = 0x84C4;
        public const int GL_TEXTURE5 = 0x84C5;
        public const int GL_TEXTURE6 = 0x84C6;
        public const int GL_TEXTURE7 = 0x84C7;
        public const int GL_TEXTURE8 = 0x84C8;
        public const int GL_TEXTURE9 = 0x84C9;
        public const int GL_TEXTURE10 = 0x84CA;
        public const int GL_TEXTURE11 = 0x84CB;
        public const int GL_TEXTURE12 = 0x84CC;
        public const int GL_TEXTURE13 = 0x84CD;
        public const int GL_TEXTURE14 = 0x84CE;
        public const int GL_TEXTURE15 = 0x84CF;
        public const int GL_TEXTURE16 = 0x84D0;
        public const int GL_TEXTURE17 = 0x84D1;
        public const int GL_TEXTURE18 = 0x84D2;
        public const int GL_TEXTURE19 = 0x84D3;
        public const int GL_TEXTURE20 = 0x84D4;
        public const int GL_TEXTURE21 = 0x84D5;
        public const int GL_TEXTURE22 = 0x84D6;
        public const int GL_TEXTURE23 = 0x84D7;
        public const int GL_TEXTURE24 = 0x84D8;
        public const int GL_TEXTURE25 = 0x84D9;
        public const int GL_TEXTURE26 = 0x84DA;
        public const int GL_TEXTURE27 = 0x84DB;
        public const int GL_TEXTURE28 = 0x84DC;
        public const int GL_TEXTURE29 = 0x84DD;
        public const int GL_TEXTURE30 = 0x84DE;
        public const int GL_TEXTURE31 = 0x84DF;
        public const int GL_ACTIVE_TEXTURE = 0x84E0;
        public const int GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
        public const int GL_MAX_TEXTURE_UNITS = 0x84E2;

        /* Texture cube map */
        public const int GL_NORMAL_MAP = 0x8511;
        public const int GL_REFLECTION_MAP = 0x8512;
        public const int GL_TEXTURE_CUBE_MAP = 0x8513;
        public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
        public const int GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
        public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

        /* Texture compression */
        public const int GL_COMPRESSED_ALPHA = 0x84E9;
        public const int GL_COMPRESSED_LUMINANCE = 0x84EA;
        public const int GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
        public const int GL_COMPRESSED_INTENSITY = 0x84EC;
        public const int GL_COMPRESSED_RGB = 0x84ED;
        public const int GL_COMPRESSED_RGBA = 0x84EE;
        public const int GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
        public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
        public const int GL_TEXTURE_COMPRESSED = 0x86A1;
        public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
        public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;

        /* Multisample */
        public const int GL_MULTISAMPLE = 0x809D;
        public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
        public const int GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
        public const int GL_SAMPLE_COVERAGE = 0x80A0;
        public const int GL_SAMPLE_BUFFERS = 0x80A8;
        public const int GL_SAMPLES = 0x80A9;
        public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
        public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
        public const int GL_MULTISAMPLE_BIT = 0x20000000;

        /* Transpose matrix */
        public const int GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
        public const int GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
        public const int GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
        public const int GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;

        /* Texture enviormental combination */
        public const int GL_COMBINE = 0x8570;
        public const int GL_COMBINE_RGB = 0x8571;
        public const int GL_COMBINE_ALPHA = 0x8572;
        public const int GL_SOURCE0_RGB = 0x8580;
        public const int GL_SOURCE1_RGB = 0x8581;
        public const int GL_SOURCE2_RGB = 0x8582;
        public const int GL_SOURCE0_ALPHA = 0x8588;
        public const int GL_SOURCE1_ALPHA = 0x8589;
        public const int GL_SOURCE2_ALPHA = 0x858A;
        public const int GL_OPERAND0_RGB = 0x8590;
        public const int GL_OPERAND1_RGB = 0x8591;
        public const int GL_OPERAND2_RGB = 0x8592;
        public const int GL_OPERAND0_ALPHA = 0x8598;
        public const int GL_OPERAND1_ALPHA = 0x8599;
        public const int GL_OPERAND2_ALPHA = 0x859A;
        public const int GL_RGB_SCALE = 0x8573;
        public const int GL_ADD_SIGNED = 0x8574;
        public const int GL_INTERPOLATE = 0x8575;
        public const int GL_SUBTRACT = 0x84E7;
        public const int GL_CONSTANT = 0x8576;
        public const int GL_PRIMARY_COLOR = 0x8577;
        public const int GL_PREVIOUS = 0x8578;

        /* Texture enviormental dot product */
        public const int GL_DOT3_RGB = 0x86AE;
        public const int GL_DOT3_RGBA = 0x86AF;

        /* Texture border clamp */
        public const int GL_CLAMP_TO_BORDER = 0x812D;

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ActiveTexture(GLenum texture);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClientActiveTexture(GLenum texture);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CompressedTexImage1D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, GLvoid data );

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CompressedTexImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, GLvoid data);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CompressedTexImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, GLvoid data);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CompressedTexSubImage1D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLint border, GLsizei imageSize, GLvoid data);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CompressedTexSubImage2D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLint border, GLsizei imageSize, GLvoid data);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CompressedTexSubImage3D(GLenum target, GLint level, GLenum internalformat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLsizei imageSize, GLvoid data);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetCompressedTexImage(GLenum target, GLint lod, GLvoid image);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord1d(GLenum target, GLdouble s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord1dv(GLenum target, GLdouble[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord1f(GLenum target, GLfloat s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord1fv(GLenum target, GLfloat[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord1i(GLenum target, GLint s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord1iv(GLenum target, GLint[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord1s(GLenum target, GLshort s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord1sv(GLenum target, GLshort[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord2d(GLenum target, GLdouble s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord2dv(GLenum target, GLdouble[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord2f(GLenum target, GLfloat s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord2fv(GLenum target, GLfloat[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord2i(GLenum target, GLint s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord2iv(GLenum target, GLint[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord2s(GLenum target, GLshort s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord2sv(GLenum target, GLshort[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord3d(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord3dv(GLenum target, GLdouble[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord3f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord3v(GLenum target, GLfloat[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord3i(GLenum target, GLint s, GLint t, GLint r, GLint q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord3iv(GLenum target, GLint[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord3s(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord3sv(GLenum target, GLshort[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord4d(GLenum target, GLdouble s, GLdouble t, GLdouble r, GLdouble q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord4dv(GLenum target, GLdouble[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord4f(GLenum target, GLfloat s, GLfloat t, GLfloat r, GLfloat q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord4v(GLenum target, GLfloat[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord4i(GLenum target, GLint s, GLint t, GLint r, GLint q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord4iv(GLenum target, GLint[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord4s(GLenum target, GLshort s, GLshort t, GLshort r, GLshort q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultiTexCoord4sv(GLenum target, GLshort[] v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadTransposeMatrixd(GLdouble[] m);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadTransposeMatrixf(GLfloat[] m);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultTransposeMatrixd(GLdouble[] m);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultTransposeMatrixf(GLfloat[] m);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void SampleCoverage(GLclampf value, GLboolean invert);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void SamplePass(GLenum pass);
    }
}
