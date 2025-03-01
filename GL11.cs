using System.Runtime.InteropServices;

namespace OpenGL.Core.GL11
{
    public class GL11
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

        public const int GL_VERSION_1_1 = 1;

        public const int GL_PROXY_TEXTURE_1D = 0x8063;
        public const int GL_PROXY_TEXTURE_2D = 0x8064;
        public const int GL_TEXTURE_PRIORITY = 0x8066;
        public const int GL_TEXTURE_RESIDENT = 0x8067;
        public const int GL_TEXTURE_BINDING_1D = 0x8068;
        public const int GL_TEXTURE_BINDING_2D = 0x8069;
        public const int GL_TEXTURE_INTERNAL_FORMAT = 0x1003;
        public const int GL_ALPHA4 = 0x803B;
        public const int GL_ALPHA8 = 0x803C;
        public const int GL_ALPHA12 = 0x803D;
        public const int GL_ALPHA16 = 0x803E;
        public const int GL_LUMINANCE4 = 0x803F;
        public const int GL_LUMINANCE8 = 0x8040;
        public const int GL_LUMINANCE12 = 0x8041;
        public const int GL_LUMINANCE16 = 0x8042;
        public const int GL_LUMINANCE4_ALPHA4 = 0x8043;
        public const int GL_LUMINANCE6_ALPHA2 = 0x8044;
        public const int GL_LUMINANCE8_ALPHA8 = 0x8045;
        public const int GL_LUMINANCE12_ALPHA4 = 0x8046;
        public const int GL_LUMINANCE12_ALPHA12 = 0x8047;
        public const int GL_LUMINANCE16_ALPHA16 = 0x8048;
        public const int GL_INTENSITY = 0x8049;
        public const int GL_INTENSITY4 = 0x804A;
        public const int GL_INTENSITY8 = 0x804B;
        public const int GL_INTENSITY12 = 0x804C;
        public const int GL_INTENSITY16 = 0x804D;
        public const int GL_R3_G3_B2 = 0x2A10;
        public const int GL_RGB4 = 0x804F;
        public const int GL_RGB5 = 0x8050;
        public const int GL_RGB8 = 0x8051;
        public const int GL_RGB10 = 0x8052;
        public const int GL_RGB12 = 0x8053;
        public const int GL_RGB16 = 0x8054;
        public const int GL_RGBA2 = 0x8055;
        public const int GL_RGBA4 = 0x8056;
        public const int GL_RGB5_A1 = 0x8057;
        public const int GL_RGBA8 = 0x8058;
        public const int GL_RGB10_A2 = 0x8059;
        public const int GL_RGBA12 = 0x805A;
        public const int GL_RGBA16 = 0x805B;
        public const int GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;
        public const int GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;
        public const int GL_ALL_CLIENT_ATTRIB_BITS = unchecked((int)0xFFFFFFFF);
        public const int GL_CLIENT_ALL_ATTRIB_BITS = unchecked((int)0xFFFFFFFF);

        /* Texture objects */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GenTextures(int n, uint[] textures);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DeleteTextures(int n, uint[] textures);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void BindTexture(int target, uint texture);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PrioritizeTextures(int n, uint[] textures, float[] priorities);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern byte AreTexturesResident(int n, uint[] textures, byte[] residences);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern byte IsTexture(uint texture);

        /* Texture mapping */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexSubImage1D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLenum format, GLenum type, GLvoid pixels);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexSubImage2D(GLenum target, GLint level, GLint xoffset, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid pixels);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyTexImage1D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLint border);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyTexImage2D(GLenum target, GLint level, GLenum internalformat, GLint x, GLint y, GLsizei width, GLsizei height, GLint border);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyTexSubImage1D(GLenum target, GLint level, GLint xoffset, GLint x, GLint y, GLsizei width);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CopyTexSubImage2D(GLenum target, GLint level, GLint xoffset, GLint yoffset, GLint x, GLint y, GLsizei width, GLsizei height);

        /* Vertex Arrays */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void VertexPointer(GLint size, GLenum type, GLsizei stride, GLvoid ptr);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void NormalPointer(GLenum type, GLsizei stride, GLvoid ptr);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ColorPointer(GLint size, GLenum type, GLsizei stride, GLvoid ptr);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void IndexPointer(GLenum type, GLsizei stride, GLvoid ptr);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void TexCoordPointer(GLint size, GLenum type, GLsizei stride, GLvoid ptr);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void EdgeFlagPointer(GLsizei stride, GLvoid ptr);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetPointerv(GLenum pname, GLvoid[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ArrayElement(GLint i);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawArrays(GLenum mode, GLint first, GLsizei count);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawElements(GLenum mode, GLsizei count, GLenum type, GLvoid indices);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void InterleavedArrays(GLenum format, GLsizei stride, GLvoid pointer);
    }
}
