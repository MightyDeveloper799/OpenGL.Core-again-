using System.Runtime.InteropServices;

namespace OpenGL.Core.GL12
{
    public class GL12
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

        public const int GL_RESCALE_NORMAL = 1;
        public const int GL_CLAMP_TO_EDGE = 0x812F;
        public const int GL_MAX_ELEMENTS_VERTICES = 0x80E8;
        public const int GL_MAX_ELEMENTS_INDICES = 0x80E9;
        public const int GL_BGR = 0x80E0;
        public const int GL_BGRA = 0x80E1;
        public const int GL_UNSIGNED_BYTE_3_3_2 = 0x8032;
        public const int GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;
        public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
        public const int GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
        public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
        public const int GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
        public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
        public const int GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
        public const int GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
        public const int GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;
        public const int GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
        public const int GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
        public const int GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
        public const int GL_SINGLE_COLOR = 0x81F9;
        public const int GL_SEPARATE_SPECULAR_COLOR = 0x81FA;
        public const int GL_TEXTURE_MIN_LOD = 0x813A;
        public const int GL_TEXTURE_MAX_LOD = 0x813B;
        public const int GL_TEXTURE_BASE_LEVEL = 0x813C;
        public const int GL_TEXTURE_MAX_LEVEL = 0x813D;
        public const int GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;
        public const int GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
        public const int GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
        public const int GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
        public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
        public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
        public const int GL_PACK_SKIP_IMAGES = 0x806B;
        public const int GL_PACK_IMAGE_HEIGHT = 0x806C;
        public const int GL_UNPACK_SKIP_IMAGES = 0x806D;
        public const int GL_UNPACK_IMAGE_HEIGHT = 0x806E;
        public const int GL_TEXTURE_3D = 0x806F;
        public const int GL_PROXY_TEXTURE_3D = 0x8070;
        public const int GL_TEXTURE_DEPTH = 0x8071;
        public const int GL_TEXTURE_WRAP_R = 0x8072;
        public const int GL_MAX_3D_TEXTURE_SIZE = 0x8073;
        public const int GL_TEXTURE_BINDING_3D = 0x806A;

        /* GL_EXT Color Table */
        public const int GL_COLOR_TABLE = 0x80D0;
        public const int GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
        public const int GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
        public const int GL_PROXY_COLOR_TABLE = 0x80D3;
        public const int GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
        public const int GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
        public const int GL_COLOR_TABLE_SCALE = 0x80D6;
        public const int GL_COLOR_TABLE_BIAS = 0x80D7;
        public const int GL_COLOR_TABLE_FORMAT = 0x80D8;
        public const int GL_COLOR_TABLE_WIDTH = 0x80D9;
        public const int GL_COLOR_TABLE_RED_SIZE = 0x80DA;
        public const int GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;
        public const int GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;
        public const int GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;
        public const int GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
        public const int GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;

        /* GL_EXT Convolution */
        public const int GL_CONVOLUTION_1D = 0x8010;
        public const int GL_CONVOLUTION_2D = 0x8011;
        public const int GL_SEPARABLE_2D = 0x8012;
        public const int GL_CONVOLUTION_BORDER_MODE = 0x8013;
        public const int GL_CONVOLUTION_FILTER_SCALE = 0x8014;
        public const int GL_CONVOLUTION_FILTER_BIAS = 0x8015;
        public const int GL_REDUCE = 0x8016;
        public const int GL_CONVOLUTION_FORMAT = 0x8017;
        public const int GL_CONVOLUTION_WIDTH = 0x8018;
        public const int GL_CONVOLUTION_HEIGHT = 0x8019;
        public const int GL_MAX_CONVOLUTION_WIDTH = 0x801A;
        public const int GL_MAX_CONVOLUTION_HEIGHT = 0x801B;
        public const int GL_POST_CONVOLUTION_RED_SCALE = 0x801C;
        public const int GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;
        public const int GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;
        public const int GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
        public const int GL_POST_CONVOLUTION_RED_BIAS = 0x8020;
        public const int GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;
        public const int GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;
        public const int GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
        public const int GL_CONSTANT_BORDER = 0x8024;
        public const int GL_REPLICATE_BORDER = 0x8153;
        public const int GL_CONVOLUTION_BORDER_COLOR = 0x8154;

        /* GL_SGI Color Matrix */
        public const int GL_COLOR_MATRIX = 0x80B1;
        public const int GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;
        public const int GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
        public const int GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
        public const int GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
        public const int GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
        public const int GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
        public const int GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
        public const int GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
        public const int GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
        public const int GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;

        /* GL_EXT Histogram */
        public const int GL_HISTOGRAM = 0x8024;
        public const int GL_PROXY_HISTOGRAM = 0x8025;
        public const int GL_HISTOGRAM_WIDTH = 0x8026;
        public const int GL_HISTOGRAM_FORMAT = 0x8027;
        public const int GL_HISTOGRAM_RED_SIZE = 0x8028;
        public const int GL_HISTOGRAM_GREEN_SIZE = 0x8029;
        public const int GL_HISTOGRAM_BLUE_SIZE = 0x802A;
        public const int GL_HISTOGRAM_ALPHA_SIZE = 0x802B;
        public const int GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;
        public const int GL_HISTOGRAM_SINK = 0x802D;
        public const int GL_MINMAX = 0x802E;
        public const int GL_MINMAX_FORMAT = 0x802F;
        public const int GL_MINMAX_SINK = 0x8030;
        public const int GL_TABLE_TOO_LARGE = 0x8031;

        /* GL_EXT Blend Color */
        public const int GL_BLEND_EQUATION = 0x8009;
        public const int GL_MIN = 0x8007;
        public const int GL_MAX = 0x8008;
        public const int GL_FUNC_ADD = 0x8006;
        public const int GL_FUNC_SUBTRACT = 0x800A;
        public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;
        public const int GL_BLEND_COLOR = 0x8005;

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawRangeElements(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, GLvoid indices);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexImage3D(GLenum target, GLint level, GLenum internalFormat, GLsizei width, GLsizei height, GLsizei depth, GLint border, GLenum format, GLenum type, GLvoid pixels);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLsizei width, GLsizei height, GLsizei depth, GLenum format, GLenum type, GLvoid pixels);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyTexSubImage3D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint zoffset, GLint x, GLint y, GLsizei width, GLsizei height);

        /* Imaging Extension */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ColorTable(GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, GLvoid table);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ColorSubTable(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, GLvoid data);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetColorTable(GLenum target, GLenum format, GLenum type, GLvoid table);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetColorTableParameterfv(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetColorTableParameteriv(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void BlendEquation(GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void BlendColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetConvolutionFilter(GLenum target, GLenum format, GLenum type, GLvoid image);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetHistogram(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid values);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetMinmax(GLenum target, GLboolean reset, GLenum format, GLenum type, GLvoid values);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Histogram(GLenum target, GLsizei width, GLenum internalFormat, GLboolean sink);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Minmax(GLenum target, GLenum internalFormat, GLboolean sink);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ResetHistogram(GLenum target);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ResetMinmax(GLenum target);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ConvolutionFilter1D(GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, GLvoid image);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ConvolutionFilter2D(GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid image);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ConvolutionParameterf(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ConvolutionParameterfv(GLenum target, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ConvolutionParameteri(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ConvolutionParameteriv(GLenum target, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ConvolutionFilter(GLenum target, GLenum format, GLenum type, GLvoid image);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetConvolutionParameterf(GLenum target, GLenum format, GLenum type, GLvoid image);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetConvolutionParameterfv(GLenum target, GLenum format, GLenum type, GLvoid image);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetConvolutionParameteri(GLenum target, GLenum format, GLenum type, GLvoid image);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetConvolutionParameteriv(GLenum target, GLenum format, GLenum type, GLvoid image);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void SeparableFilter2D(GLenum target, GLenum internalFormat, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid row, GLvoid column);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetSeparableFilter(GLenum target, GLenum format, GLenum type, GLvoid row, GLvoid column, GLvoid span);
    }
}
