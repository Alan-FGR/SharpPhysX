// Generated by minBND 5.1.91.17 - © github.com/Alan-FGR
using System;
using System.Runtime.InteropServices;
using static minBND_pinvokes;

public static unsafe partial class physx {

    public enum PxDebugColorEnum : int {
        eARGB_BLACK = -16777216,       // eARGB_BLACK = 0xff000000
        eARGB_RED = -65536,            // eARGB_RED = 0xffff0000
        eARGB_GREEN = -16711936,       // eARGB_GREEN = 0xff00ff00
        eARGB_BLUE = -16776961,        // eARGB_BLUE = 0xff0000ff
        eARGB_YELLOW = -256,           // eARGB_YELLOW = 0xffffff00
        eARGB_MAGENTA = -65281,        // eARGB_MAGENTA = 0xffff00ff
        eARGB_CYAN = -16711681,        // eARGB_CYAN = 0xff00ffff
        eARGB_WHITE = -1,              // eARGB_WHITE = 0xffffffff
        eARGB_GREY = -8355712,         // eARGB_GREY = 0xff808080
        eARGB_DARKRED = -2004353024,   // eARGB_DARKRED = 0x88880000
        eARGB_DARKGREEN = -2013231104, // eARGB_DARKGREEN = 0x88008800
        eARGB_DARKBLUE = -2013265784,  // eARGB_DARKBLUE = 0x88000088
    }

    [StructLayout(LayoutKind.Sequential, Size = 16)]
    public unsafe partial struct PxDebugPoint {
        public physx.PxVec3 pos;
        public uint color;

        public PxDebugPoint(physx.PxVec3 p, uint* c) : this((physx.PxVec3*)&p, c) {
            //ctor piping;
        }

        public PxDebugPoint(physx.PxVec3.Ref p, uint* c) : this((physx.PxVec3*)(*((IntPtr*)(&p))), c) {
            //ctor piping;
        }

        public PxDebugPoint(physx.PxVec3* p, uint* c) {

            physx.PxVec3* pvk_in_p = p;
            uint* pvk_in_c = c;
            PxDebugPoint toInit;
            var pvk_in_this = &toInit;
            void_PxDebugPoint_PxDebugPointPtr_Ctor_PxVec3_uint_(pvk_in_this, pvk_in_p, pvk_in_c);
            this = toInit;
        }

        public struct Ref {
            private IntPtr nativePtr_;
            public static implicit operator Ref(in physx.PxDebugPoint obj)
            {fixed (void* f = &obj) return new Ref {nativePtr_ = (IntPtr)f};}
        }
    }

    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public unsafe partial struct PxDebugLine {
        public physx.PxVec3 pos0;
        public uint color0;
        public physx.PxVec3 pos1;
        public uint color1;

        public PxDebugLine(physx.PxVec3 p0, physx.PxVec3 p1, uint* c) : this((physx.PxVec3*)&p0, (physx.PxVec3*)&p1, c) {
            //ctor piping;
        }

        public PxDebugLine(physx.PxVec3.Ref p0, physx.PxVec3.Ref p1, uint* c) : this((physx.PxVec3*)(*((IntPtr*)(&p0))), (physx.PxVec3*)(*((IntPtr*)(&p1))), c) {
            //ctor piping;
        }

        public PxDebugLine(physx.PxVec3* p0, physx.PxVec3* p1, uint* c) {

            physx.PxVec3* pvk_in_p0 = p0;
            physx.PxVec3* pvk_in_p1 = p1;
            uint* pvk_in_c = c;
            PxDebugLine toInit;
            var pvk_in_this = &toInit;
            void_PxDebugLine_PxDebugLinePtr_Ctor_PxVec3_PxVec3_uint_(pvk_in_this, pvk_in_p0, pvk_in_p1, pvk_in_c);
            this = toInit;
        }

        public struct Ref {
            private IntPtr nativePtr_;
            public static implicit operator Ref(in physx.PxDebugLine obj)
            {fixed (void* f = &obj) return new Ref {nativePtr_ = (IntPtr)f};}
        }
    }

    [StructLayout(LayoutKind.Sequential, Size = 48)]
    public unsafe partial struct PxDebugTriangle {
        public physx.PxVec3 pos0;
        public uint color0;
        public physx.PxVec3 pos1;
        public uint color1;
        public physx.PxVec3 pos2;
        public uint color2;

        public PxDebugTriangle(physx.PxVec3 p0, physx.PxVec3 p1, physx.PxVec3 p2, uint* c) : this((physx.PxVec3*)&p0, (physx.PxVec3*)&p1, (physx.PxVec3*)&p2, c) {
            //ctor piping;
        }

        public PxDebugTriangle(physx.PxVec3.Ref p0, physx.PxVec3.Ref p1, physx.PxVec3.Ref p2, uint* c) : this((physx.PxVec3*)(*((IntPtr*)(&p0))), (physx.PxVec3*)(*((IntPtr*)(&p1))), (physx.PxVec3*)(*((IntPtr*)(&p2))), c) {
            //ctor piping;
        }

        public PxDebugTriangle(physx.PxVec3* p0, physx.PxVec3* p1, physx.PxVec3* p2, uint* c) {

            physx.PxVec3* pvk_in_p0 = p0;
            physx.PxVec3* pvk_in_p1 = p1;
            physx.PxVec3* pvk_in_p2 = p2;
            uint* pvk_in_c = c;
            PxDebugTriangle toInit;
            var pvk_in_this = &toInit;
            void_PxDebugTriangle_PxDebugTrianglePtr_Ctor_PxVec3_PxVec3_PxVec3_uint_(pvk_in_this, pvk_in_p0, pvk_in_p1, pvk_in_p2, pvk_in_c);
            this = toInit;
        }

        public struct Ref {
            private IntPtr nativePtr_;
            public static implicit operator Ref(in physx.PxDebugTriangle obj)
            {fixed (void* f = &obj) return new Ref {nativePtr_ = (IntPtr)f};}
        }
    }

    public unsafe partial struct PxDebugTextPtr {
        private System.IntPtr nativePtr_;

        public static void Free(physx.PxDebugTextPtr ptr){
            Freer_physx_PxDebugTextPtr(ptr);
        }
        public void Free(){
            Freer_physx_PxDebugTextPtr(this);
        }

        public static physx.PxDebugTextPtr New() {
            return Ctor_PxDebugTextPtr_();
        }

        public static physx.PxDebugTextPtr New(physx.PxVec3* p, float* s, uint* c, string str) {
            physx.PxVec3* pvk_in_p = p;
            float* pvk_in_s = s;
            uint* pvk_in_c = c;
            string pvk_in_str = str;
            return Ctor_PxDebugTextPtr_PxVec3_float_uint_string(pvk_in_p, pvk_in_s, pvk_in_c, pvk_in_str);
        }

        public static physx.PxDebugTextPtr New(physx.PxVec3 p, float* s, uint* c, string str) {
            return New((physx.PxVec3*)&p, s, c, str);
        }

        public static physx.PxDebugTextPtr New(physx.PxVec3.Ref p, float* s, uint* c, string str) {
            return New((physx.PxVec3*)(*((IntPtr*)(&p))), s, c, str);
        }

        public physx.PxVec3 position {
            get { physx.PxVec3 GetRetRef; PxDebugTextPtr_GET_position(this, &GetRetRef); return GetRetRef; }
            set => PxDebugTextPtr_SET_position(this, value);
        }

        public float size {
            get => PxDebugTextPtr_GET_size(this);
            set => PxDebugTextPtr_SET_size(this, value);
        }

        public uint color {
            get => PxDebugTextPtr_GET_color(this);
            set => PxDebugTextPtr_SET_color(this, value);
        }

        public string string_ {
            get => PxDebugTextPtr_GET_string(this);
            set => PxDebugTextPtr_SET_string(this, value);
        }

    }

    public unsafe partial struct PxRenderBufferPtr {
        private System.IntPtr nativePtr_;

        public uint getNbPoints() {
            physx.PxRenderBufferPtr pvk_in_this = this;
            return uint_const_PxRenderBufferPtr_getNbPointsPtr(pvk_in_this);
        }

        public physx.PxDebugPoint* getPoints() {
            physx.PxRenderBufferPtr pvk_in_this = this;
            return PxDebugPoint_const_PxRenderBufferPtr_getPointsPtr(pvk_in_this);
        }

        public uint getNbLines() {
            physx.PxRenderBufferPtr pvk_in_this = this;
            return uint_const_PxRenderBufferPtr_getNbLinesPtr(pvk_in_this);
        }

        public physx.PxDebugLine* getLines() {
            physx.PxRenderBufferPtr pvk_in_this = this;
            return PxDebugLine_const_PxRenderBufferPtr_getLinesPtr(pvk_in_this);
        }

        public uint getNbTriangles() {
            physx.PxRenderBufferPtr pvk_in_this = this;
            return uint_const_PxRenderBufferPtr_getNbTrianglesPtr(pvk_in_this);
        }

        public physx.PxDebugTriangle* getTriangles() {
            physx.PxRenderBufferPtr pvk_in_this = this;
            return PxDebugTriangle_const_PxRenderBufferPtr_getTrianglesPtr(pvk_in_this);
        }

        public uint getNbTexts() {
            physx.PxRenderBufferPtr pvk_in_this = this;
            return uint_const_PxRenderBufferPtr_getNbTextsPtr(pvk_in_this);
        }

        public physx.PxDebugTextPtr getTexts() {
            physx.PxRenderBufferPtr pvk_in_this = this;
            return PxDebugTextPtr_const_PxRenderBufferPtr_getTextsPtr(pvk_in_this);
        }

        public void append(physx.PxRenderBufferPtr other) {
            physx.PxRenderBufferPtr pvk_in_this = this;
            physx.PxRenderBufferPtr pvk_in_other = other;
            void_PxRenderBufferPtr_appendPtr_PxRenderBufferPtr_(pvk_in_this, pvk_in_other);
        }

        public void clear() {
            physx.PxRenderBufferPtr pvk_in_this = this;
            void_PxRenderBufferPtr_clearPtr(pvk_in_this);
        }

    }
}