using System.Runtime.InteropServices;

namespace OpenGL.Core
{
    public static class GL
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

        /* OpenGL Bool values */
        public const int GL_TRUE = 0x001;
        public const int GL_FALSE = 0x000;

        /* OpenGL Data Types */
        public const int GL_BYTE = 0x1400;
        public const int GL_UNSIGNED_BYTE = 0x1401;
        public const int GL_SHORT = 0x1402;
        public const int GL_UNSIGNED_SHORT = 0x1403;
        public const int GL_INT = 0x1404;
        public const int GL_UNSIGNED_INT = 0x1405;
        public const int GL_FLOAT = 0x1406;
        public const int GL_DOUBLE = 0x140C;
        public const int GL_2_BYTES = 1407;
        public const int GL_3_BYTES = 1408;
        public const int GL_4_BYTES = 1409;

        /* OpenGL Primitives */
        public const int GL_POINTS = 0x000;
        public const int GL_LINES = 0x001;
        public const int GL_LINE_LOOP = 0x002;
        public const int GL_LINE_STRIP = 0x003;
        public const int GL_TRIANGLES = 0x004;
        public const int GL_TRIANGLE_STRIP = 0x0005;
        public const int GL_TRIANGLE_FAN = 0x0006;
        public const int GL_QUADS = 0x0007;
        public const int GL_QUAD_STRIP = 0x0008;
        public const int GL_POLYGON = 0x0009;

        /* OpenGL Vertex Arrays */
        public const int GL_VERTEX_ARRAY = 0x8074;
        public const int GL_NORMAL_ARRAY = 0x8075;
        public const int GL_COLOR_ARRAY = 0x8076;
        public const int GL_INDEX_ARRAY = 0x8077;
        public const int GL_TEXTURE_COORD_ARRAY = 0x8078;
        public const int GL_EDGE_FLAG_ARRAY = 0x8079;
        public const int GL_VERTEX_ARRAY_SIZE = 0x807A;
        public const int GL_VERTEX_ARRAY_TYPE = 0x807B;
        public const int GL_VERTEX_ARRAY_STRIDE = 0x807C;
        public const int GL_NORMAL_ARRAY_TYPE = 0x807E;
        public const int GL_NORMAL_ARRAY_STRIDE = 0x807F;
        public const int GL_COLOR_ARRAY_SIZE = 0x8081;
        public const int GL_COLOR_ARRAY_TYPE = 0x8082;
        public const int GL_COLOR_ARRAY_STRIDE = 0x8083;
        public const int GL_INDEX_ARRAY_TYPE = 0x8085;
        public const int GL_INDEX_ARRAY_STRIDE = 0x8086;
        public const int GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;
        public const int GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;
        public const int GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;
        public const int GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;
        public const int GL_VERTEX_ARRAY_POINTER = 0x808E;
        public const int GL_NORMAL_ARRAY_POINTER = 0x808F;
        public const int GL_COLOR_ARRAY_POINTER = 0x8090;
        public const int GL_INDEX_ARRAY_POINTER = 0x8091;
        public const int GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;
        public const int GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;
        public const int GL_V2F = 0x2A20;
        public const int GL_V3F = 0x2A21;
        public const int GL_C4UB_V2F = 0x2A22;
        public const int GL_C4UB_V3F = 0x2A23;
        public const int GL_C3F_V3F = 0x2A24;
        public const int GL_N3F_V3F = 0x2A25;
        public const int GL_C4F_N3F_V3F = 0x2A26;
        public const int GL_T2F_V3F = 0x2A27;
        public const int GL_T4F_V4F = 0x2A28;
        public const int GL_T2F_C4UB_V3F = 0x2A29;
        public const int GL_T2F_C3F_V3F = 0x2A2A;
        public const int GL_T2F_N3F_V3F = 0x2A2B;
        public const int GL_T2F_C4F_N3F_V3F = 0x2A2C;
        public const int GL_T4F_C4F_N3F_V4F = 0x2A2D;

        /* OpenGL Matrix Mode */
        public const int GL_MATRIX_MODE = 0x0BA0;
        public const int GL_MODELVIEW = 0x1700;
        public const int GL_PROJECTION = 0x1701;
        public const int GL_TEXTURE = 0x1702;

        /* OpenGL Points */
        public const int GL_POINT_SMOOTH = 0x0B10;
        public const int GL_POINT_SIZE = 0x0B11;
        public const int GL_POINT_SIZE_GRANULARITY = 0x0B13;
        public const int GL_POINT_SIZE_RANGE = 0x0B12;

        /* OpenGL Lines */
        public const int GL_LINE_SMOOTH = 0x0B20;
        public const int GL_LINE_STIPPLE = 0x0B24;
        public const int GL_LINE_STIPPLE_PATTERN = 0x0B25;
        public const int GL_LINE_STIPPLE_REPEAT = 0x0B26;
        public const int GL_LINE_WIDTH = 0x0B21;
        public const int GL_LINE_WIDTH_GRANULARITY = 0x0B23;
        public const int GL_LINE_WIDTH_RANGE = 0x0B22;

        /* OpenGL Polygons */
        public const int GL_POINT = 0x1B00;
        public const int GL_LINE = 0x1B01;
        public const int GL_FILL = 0x1B02;
        public const int GL_CW = 0x0900;
        public const int GL_CCW = 0x0901;
        public const int GL_FRONT = 0x0404;
        public const int GL_BACK = 0x0405;
        public const int GL_POLYGON_MODE = 0x0B40;
        public const int GL_POLYGON_SMOOTH = 0x0B41;
        public const int GL_POLYGON_STIPPLE = 0x0B42;
        public const int GL_EDGE_FLAG = 0x0B43;
        public const int GL_CULL_FACE = 0x0B44;
        public const int GL_CULL_FACE_MODE = 0x0B45;
        public const int GL_FRONT_FACE = 0x0B46;
        public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;
        public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;
        public const int GL_POLYGON_OFFSET_POINT = 0x2A01;
        public const int GL_POLYGON_OFFSET_LINE = 0x2A02;
        public const int GL_POLYGON_OFFSET_FILL = 0x8037;

        /* OpenGL Display Lists */
        public const int GL_COMPILE = 0x1300;
        public const int GL_COMPILE_AND_EXECUTE = 0x1301;
        public const int GL_LIST_BASE = 0x0B32;
        public const int GL_LIST_INDEX = 0x0B33;
        public const int GL_LIST_MODE = 0x0B30;

        /* OpenGL Depth buffer */
        public const int GL_NEVER = 0x0200;
        public const int GL_LESS = 0x0201;
        public const int GL_EQUAL = 0x0202;
        public const int GL_LEQUAL = 0x0203;
        public const int GL_GREATER = 0x0204;
        public const int GL_NOTEQUAL = 0x0205;
        public const int GL_GEQUAL = 0x0206;
        public const int GL_ALWAYS = 0x0207;
        public const int GL_DEPTH_TEST = 0x0B71;
        public const int GL_DEPTH_BITS = 0x0D56;
        public const int GL_DEPTH_CLEAR_VALUE = 0x0B73;
        public const int GL_DEPTH_FUNC = 0x0B74;
        public const int GL_DEPTH_RANGE = 0x0B70;
        public const int GL_DEPTH_WRITEMASK = 0x0B72;
        public const int GL_DEPTH_COMPONENT = 0x1902;

        /* OpenGL Lighting */
        public const int GL_LIGHTING = 0x0B50;
        public const int GL_LIGHT0 = 0x4000;
        public const int GL_LIGHT1 = 0x4001;
        public const int GL_LIGHT2 = 0x4002;
        public const int GL_LIGHT3 = 0x4003;
        public const int GL_LIGHT4 = 0x4004;
        public const int GL_LIGHT5 = 0x4005;
        public const int GL_LIGHT6 = 0x4006;
        public const int GL_LIGHT7 = 0x4007;
        public const int GL_SPOT_EXPONENT = 0x1205;
        public const int GL_SPOT_CUTOFF = 0x1206;
        public const int GL_CONSTANT_ATTENUATION = 0x1207;
        public const int GL_LINEAR_ATTENUATION = 0x1208;
        public const int GL_QUADRATIC_ATTENUATION = 0x1209;
        public const int GL_AMBIENT = 0x1200;
        public const int GL_DIFFUSE = 0x1201;
        public const int GL_SPECULAR = 0x1202;
        public const int GL_SHININESS = 0x1601;
        public const int GL_EMISSION = 0x1600;
        public const int GL_POSITION = 0x1203;
        public const int GL_SPOT_DIRECTION = 0x1204;
        public const int GL_AMBIENT_AND_DIFFUSE = 0x1602;
        public const int GL_COLOR_INDEXES = 0x1603;
        public const int GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;
        public const int GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;
        public const int GL_LIGHT_MODEL_AMBIENT = 0x0B53;
        public const int GL_FRONT_AND_BACK = 0x0408;
        public const int GL_SHADE_MODEL = 0x0B54;
        public const int GL_FLAT = 0x1D00;
        public const int GL_SMOOTH = 0x1D01;
        public const int GL_COLOR_MATERIAL = 0x0B57;
        public const int GL_COLOR_MATERIAL_FACE = 0x0B55;
        public const int GL_COLOR_MATERIAL_PARAMETER = 0x0B56;
        public const int GL_NORMALIZE = 0x0BA1;

        /* OpenGL User clipping planes */
        public const int GL_CLIP_PLANE0 = 0x3000;
        public const int GL_CLIP_PLANE1 = 0x3001;
        public const int GL_CLIP_PLANE2 = 0x3002;
        public const int GL_CLIP_PLANE3 = 0x3003;
        public const int GL_CLIP_PLANE4 = 0x3004;
        public const int GL_CLIP_PLANE5 = 0x3005;

        /* OpenGL Accumulation buffer */
        public const int GL_ACCUM_RED_BITS = 0x0D58;
        public const int GL_ACCUM_GREEN_BITS = 0x0D59;
        public const int GL_ACCUM_BLUE_BITS = 0x0D5A;
        public const int GL_ACCUM_ALPHA_BITS = 0x0D5B;
        public const int GL_ACCUM_CLEAR_VALUE = 0x0B80;
        public const int GL_ACCUM = 0x0100;
        public const int GL_ADD = 0x0104;
        public const int GL_LOAD = 0x0101;
        public const int GL_MULT = 0x0103;
        public const int GL_RETURN = 0x0102;

        /* OpenGL Alpha testing */
        public const int GL_ALPHA_TEST = 0x0BC0;
        public const int GL_ALPHA_TEST_REF = 0x0BC2;
        public const int GL_ALPHA_TEST_FUNC = 0x0BC1;

        /* OpenGL Blending */
        public const int GL_BLEND = 0x0BE2;
        public const int GL_BLEND_SRC = 0x0BE1;
        public const int GL_BLEND_DST = 0x0BE0;
        public const int GL_ZERO = 0;
        public const int GL_ONE = 1;
        public const int GL_SRC_COLOR = 0x0300;
        public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;
        public const int GL_SRC_ALPHA = 0x0302;
        public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;
        public const int GL_DST_ALPHA = 0x0304;
        public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;
        public const int GL_DST_COLOR = 0x0306;

        /* OpenGL Render Mode */
        public const int GL_FEEDBACK = 0x1C01;
        public const int GL_RENDER = 0x1C00;
        public const int GL_SELECT = 0x1C02;

        /* OpenGL Feedback */
        public const int GL_2D = 0x0600;
        public const int GL_3D = 0x0601;
        public const int GL_3D_COLOR = 0x0602;
        public const int GL_3D_COLOR_TEXTURE = 0x0603;
        public const int GL_4D_COLOR_TEXTURE = 0x0604;
        public const int GL_POINT_TOKEN = 0x0701;
        public const int GL_LINE_TOKEN = 0x0702;
        public const int GL_LINE_RESET_TOKEN = 0x0707;
        public const int GL_POLYGON_TOKEN = 0x0703;
        public const int GL_BITMAP_TOKEN = 0x0704;
        public const int GL_DRAW_PIXEL_TOKEN = 0x0705;
        public const int GL_COPY_PIXEL_TOKEN = 0x0706;
        public const int GL_PASS_THROUGH_TOKEN = 0x0700;
        public const int GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;
        public const int GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;
        public const int GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;

        /* OpenGL Selection */
        public const int GL_SELECTION_BUFFER_POINTER = 0x0DF3;
        public const int GL_SELECTION_BUFFER_SIZE = 0x0DF4;

        /* OpenGL Fog */
        public const int GL_FOG = 0x0B60;
        public const int GL_FOG_MODE = 0x0B65;
        public const int GL_FOG_DENSITY = 0x0B62;
        public const int GL_FOG_COLOR = 0x0B66;
        public const int GL_FOG_INDEX = 0x0B61;
        public const int GL_FOG_START = 0x0B63;
        public const int GL_FOG_END = 0x0B64;
        public const int GL_LINEAR = 0x2601;
        public const int GL_EXP = 0x0800;
        public const int GL_EXP2 = 0x0801;

        /* OpenGL Logic Ops */
        public const int GL_LOGIC_OP = 0x0BF1;
        public const int GL_INDEX_LOGIC_OP = 0x0BF1;
        public const int GL_COLOR_LOGIC_OP = 0x0BF2;
        public const int GL_LOGIC_OP_MODE = 0x0BF0;
        public const int GL_CLEAR = 0x1500;
        public const int GL_SET = 0x150F;
        public const int GL_COPY = 0x1503;
        public const int GL_COPY_INVERTED = 0x150C;
        public const int GL_NOOP = 0x1505;
        public const int GL_INVERT = 0x150A;
        public const int GL_AND = 0x1501;
        public const int GL_NAND = 0x150E;
        public const int GL_OR = 0x1507;
        public const int GL_NOR = 0x1508;
        public const int GL_XOR = 0x1506;
        public const int GL_EQUIV = 0x1509;
        public const int GL_AND_REVERSE = 0x1502;
        public const int GL_AND_INVERTED = 0x1504;
        public const int GL_OR_REVERSE = 0x150B;
        public const int GL_OR_INVERTED = 0x150D;

        /* OpenGL Stencil */
        public const int GL_STENCIL_TEST = 0x0B90;
        public const int GL_STENCIL_WRITEMASK = 0x0B98;
        public const int GL_STENCIL_BITS = 0x0D57;
        public const int GL_STENCIL_FUNC = 0x0B92;
        public const int GL_STENCIL_VALUE_MASK = 0x0B93;
        public const int GL_STENCIL_REF = 0x0B97;
        public const int GL_STENCIL_FAIL = 0x0B94;
        public const int GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;
        public const int GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;
        public const int GL_STENCIL_CLEAR_VALUE = 0x0B91;
        public const int GL_STENCIL_INDEX = 0x1901;
        public const int GL_KEEP = 0x1E00;
        public const int GL_REPLACE = 0x1E01;
        public const int GL_INCR = 0x1E02;
        public const int GL_DECR = 0x1E03;

        /* OpenGL Buffers, Pixel Drawing/Reading */
        public const int GL_NONE = 0;
        public const int GL_LEFT = 0x0406;
        public const int GL_RIGHT = 0x0407;
        public const int GL_FRONT_LEFT = 0x0400;
        public const int GL_FRONT_RIGHT = 0x0401;
        public const int GL_BACK_LEFT = 0x0402;
        public const int GL_BACK_RIGHT = 0x0403;
        public const int GL_AUX0 = 0x0409;
        public const int GL_AUX1 = 0x040A;
        public const int GL_AUX2 = 0x040B;
        public const int GL_AUX3 = 0x040C;
        public const int GL_COLOR_INDEX = 0x1900;
        public const int GL_RED = 0x1903;
        public const int GL_GREEN = 0x1904;
        public const int GL_BLUE = 0x1905;
        public const int GL_ALPHA = 0x1906;
        public const int GL_LUMINANCE = 0x1909;
        public const int GL_LUMINANCE_ALPHA = 0x190A;
        public const int GL_ALPHA_BITS = 0x0D55;
        public const int GL_RED_BITS = 0x0D52;
        public const int GL_GREEN_BITS = 0x0D53;
        public const int GL_BLUE_BITS = 0x0D54;
        public const int GL_INDEX_BITS = 0x0D51;
        public const int GL_SUBPIXEL_BITS = 0x0D50;
        public const int GL_AUX_BUFFERS = 0x0C00;
        public const int GL_READ_BUFFER = 0x0C02;
        public const int GL_DRAW_BUFFER = 0x0C01;
        public const int GL_DOUBLEBUFFER = 0x0C32;
        public const int GL_STEREO = 0x0C33;
        public const int GL_BITMAP = 0x1A00;
        public const int GL_COLOR = 0x1800;
        public const int GL_DEPTH = 0x1801;
        public const int GL_STENCIL = 0x1802;
        public const int GL_DITHER = 0x0BD0;
        public const int GL_RGB = 0x1907;
        public const int GL_RGBA = 0x1908;

        /* OpenGL Implementation limits */
        public const int GL_MAX_LIST_NESTING = 0x0B31;
        public const int GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35;
        public const int GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;
        public const int GL_MAX_NAME_STACK_DEPTH = 0x0D37;
        public const int GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;
        public const int GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;
        public const int GL_MAX_EVAL_ORDER = 0x0D30;
        public const int GL_MAX_LIGHTS = 0x0D31;
        public const int GL_MAX_CLIP_PLANES = 0x0D32;
        public const int GL_MAX_TEXTURE_SIZE = 0x0D33;
        public const int GL_MAX_PIXEL_MAP_TABLE = 0x0D34;
        public const int GL_MAX_VIEWPORT_DIMS = 0x0D3A;
        public const int GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;

        /* OpenGL Gets */
        public const int GL_ATTRIB_STACK_DEPTH = 0x0BB0;
        public const int GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;
        public const int GL_COLOR_CLEAR_VALUE = 0x0C22;
        public const int GL_COLOR_WRITEMASK = 0x0C23;
        public const int GL_CURRENT_COLOR = 0x0B00;
        public const int GL_CURRENT_INDEX = 0x0B01;
        public const int GL_CURRENT_NORMAL = 0x0B02;
        public const int GL_CURRENT_TEXTURE_COORDS = 0x0B03;
        public const int GL_CURRENT_RASTER_COLOR = 0x0B04;
        public const int GL_CURRENT_RASTER_INDEX = 0x0B05;
        public const int GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;
        public const int GL_CURRENT_RASTER_POSITION = 0x0B07;
        public const int GL_CURRENT_RASTER_POSITION_VALID = 0x0B08;
        public const int GL_CURRENT_RASTER_DISTANCE = 0x0B09;
        public const int GL_INDEX_CLEAR_VALUE = 0x0C20;
        public const int GL_INDEX_MODE = 0x0C30;
        public const int GL_INDEX_WRITEMASK = 0x0C21;
        public const int GL_MODELVIEW_MATRIX = 0x0BA6;
        public const int GL_MODELVIEW_STACK_DEPTH = 0x0BA3;
        public const int GL_NAME_STACK_DEPTH = 0x0D70;
        public const int GL_PROJECTION_MATRIX = 0x0BA7;
        public const int GL_PROJECTION_STACK_DEPTH = 0x0BA4;
        public const int GL_RENDER_MODE = 0x0C40;
        public const int GL_RGBA_MODE = 0x0C31;
        public const int GL_TEXTURE_MATRIX = 0x0BA8;
        public const int GL_TEXTURE_STACK_DEPTH = 0x0BA5;
        public const int GL_VIEWPORT = 0x0BA2;

        /* OpenGL Evaluators */
        public const int GL_AUTO_NORMAL = 0x0D80;
        public const int GL_MAP1_COLOR_4 = 0x0D90;
        public const int GL_MAP1_INDEX = 0x0D91;
        public const int GL_MAP1_NORMAL = 0x0D92;
        public const int GL_MAP1_TEXTURE_COORD_1 = 0x0D93;
        public const int GL_MAP1_TEXTURE_COORD_2 = 0x0D94;
        public const int GL_MAP1_TEXTURE_COORD_3 = 0x0D95;
        public const int GL_MAP1_TEXTURE_COORD_4 = 0x0D96;
        public const int GL_MAP1_VERTEX_3 = 0x0D97;
        public const int GL_MAP1_VERTEX_4 = 0x0D98;
        public const int GL_MAP2_COLOR_4 = 0x0DB0;
        public const int GL_MAP2_INDEX = 0x0DB1;
        public const int GL_MAP2_NORMAL = 0x0DB2;
        public const int GL_MAP2_TEXTURE_COORD_1 = 0x0DB3;
        public const int GL_MAP2_TEXTURE_COORD_2 = 0x0DB4;
        public const int GL_MAP2_TEXTURE_COORD_3 = 0x0DB5;
        public const int GL_MAP2_TEXTURE_COORD_4 = 0x0DB6;
        public const int GL_MAP2_VERTEX_3 = 0x0DB7;
        public const int GL_MAP2_VERTEX_4 = 0x0DB8;
        public const int GL_COEFF = 0x0A00;
        public const int GL_ORDER = 0x0A01;
        public const int GL_DOMAIN = 0x0A02;

        /* OpenGL Hints */
        public const int GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;
        public const int GL_POINT_SMOOTH_HINT = 0x0C51;
        public const int GL_LINE_SMOOTH_HINT = 0x0C52;
        public const int GL_POLYGON_SMOOTH_HINT = 0x0C53;
        public const int GL_FOG_HINT = 0x0C54;
        public const int GL_DONT_CARE = 0x1100;
        public const int GL_FASTEST = 0x1101;
        public const int GL_NICEST = 0x1102;

        /* OpenGL Scissor box */
        public const int GL_SCISSOR_TEST = 0x0C11;
        public const int GL_SCISSOR_BOX = 0x0C10;

        /* OpenGL Pixel Mode / Transfer */
        public const int GL_MAP_COLOR = 0x0D10;
        public const int GL_MAP_STENCIL = 0x0D11;
        public const int GL_INDEX_SHIFT = 0x0D12;
        public const int GL_INDEX_OFFSET = 0x0D13;
        public const int GL_RED_SCALE = 0x0D14;
        public const int GL_RED_BIAS = 0x0D15;
        public const int GL_GREEN_SCALE = 0x0D18;
        public const int GL_GREEN_BIAS = 0x0D19;
        public const int GL_BLUE_SCALE = 0x0D1A;
        public const int GL_BLUE_BIAS = 0x0D1B;
        public const int GL_ALPHA_SCALE = 0x0D1C;
        public const int GL_ALPHA_BIAS = 0x0D1D;
        public const int GL_DEPTH_SCALE = 0x0D1E;
        public const int GL_DEPTH_BIAS = 0x0D1F;
        public const int GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;
        public const int GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;
        public const int GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;
        public const int GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;
        public const int GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;
        public const int GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;
        public const int GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;
        public const int GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;
        public const int GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;
        public const int GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;
        public const int GL_PIXEL_MAP_S_TO_S = 0x0C71;
        public const int GL_PIXEL_MAP_I_TO_I = 0x0C70;
        public const int GL_PIXEL_MAP_I_TO_R = 0x0C72;
        public const int GL_PIXEL_MAP_I_TO_G = 0x0C73;
        public const int GL_PIXEL_MAP_I_TO_B = 0x0C74;
        public const int GL_PIXEL_MAP_I_TO_A = 0x0C75;
        public const int GL_PIXEL_MAP_R_TO_R = 0x0C76;
        public const int GL_PIXEL_MAP_G_TO_G = 0x0C77;
        public const int GL_PIXEL_MAP_B_TO_B = 0x0C78;
        public const int GL_PIXEL_MAP_A_TO_A = 0x0C79;
        public const int GL_PACK_ALIGNMENT = 0x0D05;
        public const int GL_PACK_LSB_FIRST = 0x0D01;
        public const int GL_PACK_ROW_LENGTH = 0x0D02;
        public const int GL_PACK_SKIP_PIXELS = 0x0D04;
        public const int GL_PACK_SKIP_ROWS = 0x0D03;
        public const int GL_PACK_SWAP_BYTES = 0x0D00;
        public const int GL_UNPACK_ALIGNMENT = 0x0CF5;
        public const int GL_UNPACK_LSB_FIRST = 0x0CF1;
        public const int GL_UNPACK_ROW_LENGTH = 0x0CF2;
        public const int GL_UNPACK_SKIP_PIXELS = 0x0CF4;
        public const int GL_UNPACK_SKIP_ROWS = 0x0CF3;
        public const int GL_UNPACK_SWAP_BYTES = 0x0CF0;
        public const int GL_ZOOM_X = 0x0D16;
        public const int GL_ZOOM_Y = 0x0D17;

        /* OpenGL Texture Mapping */
        public const int GL_TEXTURE_ENV = 0x2300;
        public const int GL_TEXTURE_ENV_MODE = 0x2200;
        public const int GL_TEXTURE_1D = 0x0DE0;
        public const int GL_TEXTURE_2D = 0x0DE1;
        public const int GL_TEXTURE_WRAP_S = 0x2802;
        public const int GL_TEXTURE_WRAP_T = 0x2803;
        public const int GL_TEXTURE_MAG_FILTER = 0x2800;
        public const int GL_TEXTURE_MIN_FILTER = 0x2801;
        public const int GL_TEXTURE_ENV_COLOR = 0x2201;
        public const int GL_TEXTURE_GEN_S = 0x0C60;
        public const int GL_TEXTURE_GEN_T = 0x0C61;
        public const int GL_TEXTURE_GEN_R = 0x0C62;
        public const int GL_TEXTURE_GEN_Q = 0x0C63;
        public const int GL_TEXTURE_GEN_MODE = 0x2500;
        public const int GL_TEXTURE_BORDER_COLOR = 0x1004;
        public const int GL_TEXTURE_WIDTH = 0x1000;
        public const int GL_TEXTURE_HEIGHT = 0x1001;
        public const int GL_TEXTURE_BORDER = 0x1005;
        public const int GL_TEXTURE_COMPONENTS = 0x1003;
        public const int GL_TEXTURE_RED_SIZE = 0x805C;
        public const int GL_TEXTURE_GREEN_SIZE = 0x805D;
        public const int GL_TEXTURE_BLUE_SIZE = 0x805E;
        public const int GL_TEXTURE_ALPHA_SIZE = 0x805F;
        public const int GL_TEXTURE_LUMINANCE_SIZE = 0x8060;
        public const int GL_TEXTURE_INTENSITY_SIZE = 0x8061;
        public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;
        public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;
        public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;
        public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;
        public const int GL_OBJECT_LINEAR = 0x2401;
        public const int GL_OBJECT_PLANE = 0x2501;
        public const int GL_EYE_LINEAR = 0x2400;
        public const int GL_EYE_PLANE = 0x2502;
        public const int GL_SPHERE_MAP = 0x2402;
        public const int GL_DECAL = 0x2101;
        public const int GL_MODULATE = 0x2100;
        public const int GL_NEAREST = 0x2600;
        public const int GL_REPEAT = 0x2901;
        public const int GL_CLAMP = 0x2900;
        public const int GL_S = 0x2000;
        public const int GL_T = 0x2001;
        public const int GL_R = 0x2002;
        public const int GL_Q = 0x2003;

        /* OpenGL Utility */
        public const int GL_VENDOR = 0x1F00;
        public const int GL_RENDERER = 0x1F01;
        public const int GL_VERSION = 0x1F02;
        public const int GL_EXTENSIONS = 0x1F03;

        /* OpenGL Errors */
        public const int GL_NO_ERROR = 0;
        public const int GL_INVALID_ENUM = 0x0500;
        public const int GL_INVALID_VALUE = 0x0501;
        public const int GL_INVALID_OPERATION = 0x0502;
        public const int GL_STACK_OVERFLOW = 0x0503;
        public const int GL_STACK_UNDERFLOW = 0x0504;
        public const int GL_OUT_OF_MEMORY = 0x0505;

        /* OpenGL glPush / PopAttrib bits */
        public const int GL_CURRENT_BIT = 0x00000001;
        public const int GL_POINT_BIT = 0x00000002;
        public const int GL_LINE_BIT = 0x00000004;
        public const int GL_POLYGON_BIT = 0x00000008;
        public const int GL_POLYGON_STIPPLE_BIT = 0x00000010;
        public const int GL_PIXEL_MODE_BIT = 0x00000020;
        public const int GL_LIGHTING_BIT = 0x00000040;
        public const int GL_FOG_BIT = 0x00000080;
        public const int GL_DEPTH_BUFFER_BIT = 0x00000100;
        public const int GL_ACCUM_BUFFER_BIT = 0x00000200;
        public const int GL_STENCIL_BUFFER_BIT = 0x00000400;
        public const int GL_VIEWPORT_BIT = 0x00000800;
        public const int GL_TRANSFORM_BIT = 0x00001000;
        public const int GL_ENABLE_BIT = 0x00002000;
        public const int GL_COLOR_BUFFER_BIT = 0x00004000;
        public const int GL_HINT_BIT = 0x00008000;
        public const int GL_EVAL_BIT = 0x00010000;
        public const int GL_LIST_BIT = 0x00020000;
        public const int GL_TEXTURE_BIT = 0x00040000;
        public const int GL_SCISSOR_BIT = 0x00080000;
        public const int GL_ALL_ATTRIB_BITS = 0x000FFFFF;

        /* Miscellaneous Methods */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClearIndex(GLfloat c);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClearColor(GLclampf red, GLclampf green, GLclampf blue, GLclampf alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Clear(GLbitfield mask);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void IndexMask(GLuint mask);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ColorMask(GLboolean red, GLboolean green, GLboolean blue, GLboolean alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void AlphaFunc(GLenum func, GLclampf refer);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void BlendFunc(GLenum sfactor, GLenum dfactor);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void LogicOp(GLenum opcode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void CullFace(GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void FrontFace(GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PointSize(GLfloat size);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void LineWidth(GLfloat width);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void LineStipple(GLint factor, GLushort pattern);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PolygonMode(GLenum face, GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PolygonOffset(GLfloat factor, GLfloat units);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PolygonStipple(GLubyte mask);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetPolygonStipple(GLubyte[] mask);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void EdgeFlag(GLboolean flag);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Scissor(GLint x, GLint y, GLsizei width, GLsizei height);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClipPlane(GLenum plane, GLdouble[] equation);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetClipPlane(GLenum plane, GLdouble[] equation);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DrawBuffer(GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ReadBuffer(GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Enable(GLenum cap);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Disable(GLenum cap);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern GLboolean IsEnabled(GLenum cap);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void EnableClientState(GLenum cap);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DisableClientState(GLenum cap);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetBooleanv(GLenum pname, GLboolean param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetDoublev(GLenum pname, GLboolean param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetFloatv(GLenum pname, GLboolean param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetIntv(GLenum pname, GLint param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PushAttrib(GLbitfield mask);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PopAttrib();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PushClientAttrib(GLbitfield mask);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PopClientAttrib();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern GLint RenderMode(GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern GLenum GetError();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern GLubyte GetString(GLenum name);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Finish();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Flush();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Hint(GLenum target, GLenum mode);

        /* Depth buffers */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void ClearDepth(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DepthFunc(GLenum func);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DepthMask(GLboolean mask);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void DepthRange(GLclampd near_val, GLclampd far_val);

        /* Transformation */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MatrixMode(GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Ortho(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble near_val, GLdouble far_val);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Frustum(GLdouble left, GLdouble right, GLdouble bottom, GLdouble top, GLdouble near_val, GLdouble far_val);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Viewport(GLint x, GLint y, GLsizei width, GLsizei height);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PushMatrix();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void PopMatrix();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadIndentity();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadBindings();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadMatrixd(GLdouble m);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void LoadMatrixf(GLfloat m);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultMatrixd(GLdouble m);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void MultMatrixf(GLfloat m);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rotated(GLdouble angle, GLdouble x, GLdouble y, GLdouble z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Rotatef(GLfloat angle, GLfloat x, GLfloat y, GLfloat z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Scaled(GLdouble x, GLdouble y, GLdouble z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Scalef(GLfloat x, GLfloat y, GLfloat z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Translated(GLdouble x, GLdouble y, GLdouble z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern void Translatef(GLfloat x, GLfloat y, GLfloat z);

        /* Display Lists */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern GLboolean IsList(GLuint list);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void DeleteLists(GLuint list, GLsizei range);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern GLuint GenLists(GLsizei range);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void NewList(GLuint list, GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EndList();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void CallList(GLuint list);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void CallLists(GLsizei n, GLenum type, GLvoid lists);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void ListBase(GLuint bases);

        /* Drawing Functions */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Begin(GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void End();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex2d(GLdouble x, GLdouble y);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex2f(GLfloat x, GLfloat y);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex2i(GLint x, GLint y);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex2s(GLshort x, GLshort y);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex3d(GLdouble x, GLdouble y, GLdouble z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex3f(GLfloat x, GLfloat y, GLfloat z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex3i(GLint x, GLint y, GLint z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex3s(GLshort x, GLshort y, GLshort z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex4i(GLint x, GLint y, GLint z, GLint w);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Vertex4s(GLshort x, GLshort y, GLshort z, GLshort w);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Normal3b(GLbyte nx, GLbyte ny, GLbyte nz);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Normal3d(GLdouble nx, GLdouble ny, GLdouble nz);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Normal3f(GLfloat nx, GLfloat ny, GLfloat nz);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Normal3i(GLint nx, GLint ny, GLint nz);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Normal3s(GLshort nx, GLshort ny, GLshort nz);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Indexd(GLdouble c);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Indexf(GLfloat c);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Indexi(GLint c);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Indexs(GLshort c);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color3b(GLbyte red, GLbyte green, GLbyte blue);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color3d(GLdouble red, GLdouble green, GLdouble blue);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color3f(GLfloat red, GLfloat green, GLfloat blue);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color3i(GLint red, GLint green, GLint blue);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color3s(GLshort red, GLshort green, GLshort blue);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color3ub(GLubyte red, GLubyte green, GLubyte blue);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color3ui(GLuint red, GLuint green, GLuint blue);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color3us(GLushort red, GLushort green, GLushort blue);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color4b(GLbyte red, GLbyte green, GLbyte blue, GLbyte alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color4d(GLdouble red, GLdouble green, GLdouble blue, GLdouble alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color4f(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color4i(GLint red, GLint green, GLint blue, GLint alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color4s(GLshort red, GLshort green, GLshort blue, GLshort alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color4ub(GLubyte red, GLubyte green, GLubyte blue, GLubyte alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color4ui(GLuint red, GLuint green, GLuint blue, GLuint alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Color4us(GLushort red, GLushort green, GLushort blue, GLushort alpha);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord1d(GLdouble s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord1f(GLfloat s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord1i(GLint s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord1s(GLshort s);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord2d(GLdouble s, GLdouble t);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord2f(GLfloat s, GLfloat t);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord2i(GLint s, GLint t);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord2s(GLshort s, GLshort t);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord3d(GLdouble s, GLdouble t, GLdouble r);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord3f(GLfloat s, GLfloat t, GLfloat r);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord3i(GLint s, GLint t, GLint r);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord3s(GLshort s, GLshort t, GLshort r);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord4d(GLdouble s, GLdouble t, GLdouble r, GLdouble q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord4f(GLfloat s, GLfloat t, GLfloat r, GLfloat q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord4i(GLint s, GLint t, GLint r, GLint q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexCoord4s(GLshort s, GLshort t, GLshort r, GLshort q);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos2d(GLdouble x, GLdouble y);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos2f(GLfloat x, GLfloat y);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos2i(GLint x, GLint y);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos2s(GLshort x, GLshort y);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos3d(GLdouble x, GLdouble y, GLdouble z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos3f(GLfloat x, GLfloat y, GLfloat z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos3i(GLint x, GLint y, GLint z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos3s(GLshort x, GLshort y, GLshort z);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos4d(GLdouble x, GLdouble y, GLdouble z, GLdouble w);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos4f(GLfloat x, GLfloat y, GLfloat z, GLfloat w);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos4i(GLint x, GLint y, GLint z, GLint w);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void RasterPos4s(GLshort x, GLshort y, GLshort z, GLshort w);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Rectd(GLdouble x1, GLdouble y1, GLdouble x2, GLdouble y2);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Rectf(GLfloat x1, GLfloat y1, GLfloat x2, GLfloat y2);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Recti(GLint x1, GLint y1, GLint x2, GLint y2);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Rects(GLshort x1, GLshort y1, GLshort x2, GLshort y2);

        /* Lighting */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void ShadeModel(GLenum mode);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Lightf(GLenum light, GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Lighti(GLenum light, GLenum pname, GLint param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Lightfv(GLenum light, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Lightiv(GLenum light, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetLightfv(GLenum light, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetLightiv(GLenum light, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void LightModelf(GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void LightModeli(GLenum pname, GLint param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void LightModelfv(GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void LightModeliv(GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Materialf(GLenum face, GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Materiali(GLenum face, GLenum pname, GLint param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Materialfv(GLenum face, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Materialiv(GLenum face, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetMaterialfv(GLenum face, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetMaterialiv(GLenum face, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void ColorMaterial(GLenum face, GLenum mode);

        /* Raster Functions | Methods */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void PixelStoref(GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void PixelStorei(GLenum pname, GLint param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void ReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid pixels);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void DrawPixels(GLsizei width, GLsizei height, GLenum format, GLenum type, GLvoid pixels);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void CopyPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum type);

        /* Stencil Buffer */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void StencilFunc(GLenum func, GLint refer, GLuint mask);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void StencilMask(GLuint mask);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void StencilOp(GLenum fail, GLenum zfail, GLenum zpass);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void ClearStencil(GLint s);

        /* Texture Mapping */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexGend(GLenum coord, GLenum pname, GLdouble param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexGenf(GLenum coord, GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexGeni(GLenum coord, GLenum pname, GLint param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexGendv(GLenum coord, GLenum pname, GLdouble[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexGenfv(GLenum coord, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexGeniv(GLenum coord, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexGendv(GLenum target, GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexGenfv(GLenum target, GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexGeniv(GLenum target, GLenum pname, GLint param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexEnvf(GLenum target, GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexEnvi(GLenum target, GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexEnvfv(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexEnviv(GLenum target, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexEnvfv(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexEnviv(GLenum target, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexParameterf(GLenum target, GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexParameteri(GLenum target, GLenum pname, GLint param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexParameterfv(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexParameteriv(GLenum target, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexParameterfv(GLenum target, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexParameteriv(GLenum target, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexLevelParameterfv(GLenum target, GLint level, GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexLevelParameteriv(GLenum target, GLint level, GLenum pname, GLint[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexImage1D(GLenum target, GLint level, GLint internalFormat, GLsizei width, GLint border, GLenum format, GLenum type, GLvoid pixels);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void TexImage2D(GLenum target, GLint level, GLint internalFormat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, GLvoid pixels);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void GetTexImage(GLenum coord, GLenum pname, GLdouble[] param);

        /* Evaluators */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Map1d(GLenum target, GLdouble u1, GLdouble u2, GLint stride, GLint order, GLdouble[] points);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Map1f(GLenum target, GLfloat u1, GLfloat u2, GLint stride, GLint order, GLfloat[] points);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Map2d(GLenum target, GLdouble u1, GLdouble u2, GLint ustride, GLint uorder, GLdouble v1, GLdouble v2, GLint vstride, GLint vorder, GLdouble[] points);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Map2f(GLenum target, GLfloat u1, GLfloat u2, GLint ustride, GLint uorder, GLfloat v1, GLfloat v2, GLint vstride, GLint vorder, GLfloat[] points);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalCoord1d(GLdouble u);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalCoord1f(GLfloat u);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalCoord1dv(GLdouble[] u);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalCoord1fv(GLfloat[] u);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalCoord2d(GLdouble u, GLdouble v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalCoord2f(GLfloat u, GLfloat v);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalCoord2dv(GLdouble[] u);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalCoord2fv(GLfloat[] u);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void MapGrid1d(GLint un, GLdouble u1, GLdouble u2);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void MapGrid1f(GLint un, GLfloat u1, GLfloat u2);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void MapGrid2d(GLint un, GLdouble u1, GLdouble u2, GLint vn, GLdouble v1, GLdouble v2);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void MapGrid2f(GLint un, GLfloat u1, GLfloat u2, GLint vn, GLfloat v1, GLfloat v2);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalPoint1(GLint i);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalPoint2(GLint i, GLint j);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalMesh1(GLenum mode, GLint i1, GLint i2);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void EvalMesh2(GLenum mode, GLint i1, GLint i2, GLint j1, GLint j2);

        /* Fogs */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Fogf(GLenum pname, GLfloat param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Fogi(GLenum pname, GLint param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Fogfv(GLenum pname, GLfloat[] param);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void Fogiv(GLenum pname, GLint[] param);

        /* Selection and Feedbacks */
        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void FeedbackBuffer(GLsizei size, GLenum type, GLfloat[] buffer);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void PassThrough(GLfloat token);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void SelectBuffer(GLsizei size, GLuint[] buffer);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void InitNames();

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void LoadName(GLuint name);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void PushName(GLuint name);

        [DllImport("opengl32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void PopName();
    }
}
