// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace fb
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct cunitTB : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static cunitTB GetRootAscunitTB(ByteBuffer _bb) { return GetRootAscunitTB(_bb, new cunitTB()); }
  public static cunitTB GetRootAscunitTB(ByteBuffer _bb, cunitTB obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public cunitTB __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public fb.cunitTR? Cunittrs(int j) { int o = __p.__offset(4); return o != 0 ? (fb.cunitTR?)(new fb.cunitTR()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int CunittrsLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<fb.cunitTB> CreatecunitTB(FlatBufferBuilder builder,
      VectorOffset cunittrsOffset = default(VectorOffset)) {
    builder.StartTable(1);
    cunitTB.AddCunittrs(builder, cunittrsOffset);
    return cunitTB.EndcunitTB(builder);
  }

  public static void StartcunitTB(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddCunittrs(FlatBufferBuilder builder, VectorOffset cunittrsOffset) { builder.AddOffset(0, cunittrsOffset.Value, 0); }
  public static VectorOffset CreateCunittrsVector(FlatBufferBuilder builder, Offset<fb.cunitTR>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateCunittrsVectorBlock(FlatBufferBuilder builder, Offset<fb.cunitTR>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartCunittrsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<fb.cunitTB> EndcunitTB(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<fb.cunitTB>(o);
  }
  public static void FinishcunitTBBuffer(FlatBufferBuilder builder, Offset<fb.cunitTB> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedcunitTBBuffer(FlatBufferBuilder builder, Offset<fb.cunitTB> offset) { builder.FinishSizePrefixed(offset.Value); }
};

public struct cunitTR : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static cunitTR GetRootAscunitTR(ByteBuffer _bb) { return GetRootAscunitTR(_bb, new cunitTR()); }
  public static cunitTR GetRootAscunitTR(ByteBuffer _bb, cunitTR obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public cunitTR __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public int _id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public float Baseatk { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Sp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Hp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Attackdistance { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Attackinterval { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<fb.cunitTR> CreatecunitTR(FlatBufferBuilder builder,
      int _id = 0,
      float baseatk = 0.0f,
      float sp = 0.0f,
      float hp = 0.0f,
      float attackdistance = 0.0f,
      float attackinterval = 0.0f) {
    builder.StartTable(6);
    cunitTR.AddAttackinterval(builder, attackinterval);
    cunitTR.AddAttackdistance(builder, attackdistance);
    cunitTR.AddHp(builder, hp);
    cunitTR.AddSp(builder, sp);
    cunitTR.AddBaseatk(builder, baseatk);
    cunitTR.Add_id(builder, _id);
    return cunitTR.EndcunitTR(builder);
  }

  public static void StartcunitTR(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void Add_id(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddBaseatk(FlatBufferBuilder builder, float baseatk) { builder.AddFloat(1, baseatk, 0.0f); }
  public static void AddSp(FlatBufferBuilder builder, float sp) { builder.AddFloat(2, sp, 0.0f); }
  public static void AddHp(FlatBufferBuilder builder, float hp) { builder.AddFloat(3, hp, 0.0f); }
  public static void AddAttackdistance(FlatBufferBuilder builder, float attackdistance) { builder.AddFloat(4, attackdistance, 0.0f); }
  public static void AddAttackinterval(FlatBufferBuilder builder, float attackinterval) { builder.AddFloat(5, attackinterval, 0.0f); }
  public static Offset<fb.cunitTR> EndcunitTR(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<fb.cunitTR>(o);
  }
};


}
