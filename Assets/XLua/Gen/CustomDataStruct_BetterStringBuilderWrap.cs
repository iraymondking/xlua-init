#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class CustomDataStructBetterStringBuilderWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(CustomDataStruct.BetterStringBuilder);
			Utils.BeginObjectRegister(type, L, translator, 0, 15, 4, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ClearBuffer", _m_ClearBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Append", _m_Append);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AppendFormat", _m_AppendFormat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AppendLine", _m_AppendLine);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyTo", _m_CopyTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "EnsureCapacity", _m_EnsureCapacity);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Equals", _m_Equals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PartEquals", _m_PartEquals);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Insert", _m_Insert);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Remove", _m_Remove);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Replace", _m_Replace);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToString", _m_ToString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToLower", _m_ToLower);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ToUpper", _m_ToUpper);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "BufferSize", _g_get_BufferSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Capacity", _g_get_Capacity);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Length", _g_get_Length);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MaxCapacity", _g_get_MaxCapacity);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "Capacity", _s_set_Capacity);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Length", _s_set_Length);
            
			
			Utils.EndObjectRegister(type, L, translator, __CSIndexer, __NewIndexer,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Cleanup", _m_Cleanup_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 4 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && translator.Assignable<CustomDataStruct.BetterStringBuilderBufferType>(L, 4))
				{
					int _stringCapacity = LuaAPI.xlua_tointeger(L, 2);
					int _localBufferCapacity = LuaAPI.xlua_tointeger(L, 3);
					CustomDataStruct.BetterStringBuilderBufferType _bufferType;translator.Get(L, 4, out _bufferType);
					
					var gen_ret = new CustomDataStruct.BetterStringBuilder(_stringCapacity, _localBufferCapacity, _bufferType);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 3 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					int _stringCapacity = LuaAPI.xlua_tointeger(L, 2);
					int _localBufferCapacity = LuaAPI.xlua_tointeger(L, 3);
					
					var gen_ret = new CustomDataStruct.BetterStringBuilder(_stringCapacity, _localBufferCapacity);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to CustomDataStruct.BetterStringBuilder constructor!");
            
        }
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __CSIndexer(RealStatePtr L)
        {
			try {
			    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (translator.Assignable<CustomDataStruct.BetterStringBuilder>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2))
				{
					
					CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
					int index = LuaAPI.xlua_tointeger(L, 2);
					LuaAPI.lua_pushboolean(L, true);
					LuaAPI.xlua_pushinteger(L, gen_to_be_invoked[index]);
					return 2;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
            LuaAPI.lua_pushboolean(L, false);
			return 1;
        }
		
        
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        public static int __NewIndexer(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
			try {
				
				if (translator.Assignable<CustomDataStruct.BetterStringBuilder>(L, 1) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3))
				{
					
					CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
					int key = LuaAPI.xlua_tointeger(L, 2);
					gen_to_be_invoked[key] = (char)LuaAPI.xlua_tointeger(L, 3);
					LuaAPI.lua_pushboolean(L, true);
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
			
			LuaAPI.lua_pushboolean(L, false);
            return 1;
        }
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cleanup_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    CustomDataStruct.BetterStringBuilder.Cleanup(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ClearBuffer(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ClearBuffer(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Append(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    byte _value = (byte)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _value = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    uint _value = LuaAPI.xlua_touint(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    char _value = (char)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isuint64(L, 2))) 
                {
                    ulong _value = LuaAPI.lua_touint64(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))) 
                {
                    long _value = LuaAPI.lua_toint64(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    short _value = (short)LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    double _value = LuaAPI.lua_tonumber(L, 2);
                    int _precision = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Append( _value, _precision );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    float _value = (float)LuaAPI.lua_tonumber(L, 2);
                    int _precision = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Append( _value, _precision );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    char _value = (char)LuaAPI.xlua_tointeger(L, 2);
                    int _repeatCount = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Append( _value, _repeatCount );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _value = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<object>(L, 2)) 
                {
                    object _value = translator.GetObject(L, 2, typeof(object));
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<char[]>(L, 2)) 
                {
                    char[] _value = (char[])translator.GetObject(L, 2, typeof(char[]));
                    
                    gen_to_be_invoked.Append( _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _value = LuaAPI.lua_tostring(L, 2);
                    int _startIndex = LuaAPI.xlua_tointeger(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.Append( _value, _startIndex, _count );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<char[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    char[] _value = (char[])translator.GetObject(L, 2, typeof(char[]));
                    int _startIndex = LuaAPI.xlua_tointeger(L, 3);
                    int _charCount = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.Append( _value, _startIndex, _charCount );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to CustomDataStruct.BetterStringBuilder.Append!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AppendFormat(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 2);
                    int _arg0 = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.AppendFormat( _format, _arg0 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 2);
                    int _arg0 = LuaAPI.xlua_tointeger(L, 3);
                    int _arg1 = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.AppendFormat( _format, _arg0, _arg1 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 2);
                    int _arg0 = LuaAPI.xlua_tointeger(L, 3);
                    int _arg1 = LuaAPI.xlua_tointeger(L, 4);
                    int _arg2 = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.AppendFormat( _format, _arg0, _arg1, _arg2 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 2);
                    object _arg0 = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.AppendFormat( _format, _arg0 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 2);
                    object _arg0 = translator.GetObject(L, 3, typeof(object));
                    object _arg1 = translator.GetObject(L, 4, typeof(object));
                    
                    gen_to_be_invoked.AppendFormat( _format, _arg0, _arg1 );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<object>(L, 4)&& translator.Assignable<object>(L, 5)) 
                {
                    string _format = LuaAPI.lua_tostring(L, 2);
                    object _arg0 = translator.GetObject(L, 3, typeof(object));
                    object _arg1 = translator.GetObject(L, 4, typeof(object));
                    object _arg2 = translator.GetObject(L, 5, typeof(object));
                    
                    gen_to_be_invoked.AppendFormat( _format, _arg0, _arg1, _arg2 );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to CustomDataStruct.BetterStringBuilder.AppendFormat!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AppendLine(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.AppendLine(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _value = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.AppendLine( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to CustomDataStruct.BetterStringBuilder.AppendLine!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _sourceIndex = LuaAPI.xlua_tointeger(L, 2);
                    char[] _destination = (char[])translator.GetObject(L, 3, typeof(char[]));
                    int _destinationIndex = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.CopyTo( _sourceIndex, _destination, _destinationIndex, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EnsureCapacity(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _capacity = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.EnsureCapacity( _capacity );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Equals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Text.StringBuilder>(L, 2)) 
                {
                    System.Text.StringBuilder _sb = (System.Text.StringBuilder)translator.GetObject(L, 2, typeof(System.Text.StringBuilder));
                    
                        var gen_ret = gen_to_be_invoked.Equals( _sb );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<CustomDataStruct.BetterStringBuilder>(L, 2)) 
                {
                    CustomDataStruct.BetterStringBuilder _sb = (CustomDataStruct.BetterStringBuilder)translator.GetObject(L, 2, typeof(CustomDataStruct.BetterStringBuilder));
                    
                        var gen_ret = gen_to_be_invoked.Equals( _sb );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _str = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.Equals( _str );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _str = LuaAPI.lua_tostring(L, 2);
                    int _startIndex = LuaAPI.xlua_tointeger(L, 3);
                    int _length = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.Equals( _str, _startIndex, _length );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to CustomDataStruct.BetterStringBuilder.Equals!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PartEquals(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _str = LuaAPI.lua_tostring(L, 2);
                    int _selfPartStartIndex = LuaAPI.xlua_tointeger(L, 3);
                    int _slefPartLength = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = gen_to_be_invoked.PartEquals( _str, _selfPartStartIndex, _slefPartLength );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Insert(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    short _value = (short)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    int _value = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isint64(L, 3))) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    long _value = LuaAPI.lua_toint64(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) || LuaAPI.lua_isuint64(L, 3))) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    ulong _value = LuaAPI.lua_touint64(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    uint _value = LuaAPI.xlua_touint(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    bool _value = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    byte _value = (byte)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    char _value = (char)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    float _value = (float)LuaAPI.lua_tonumber(L, 3);
                    int _precision = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.Insert( _index, _value, _precision );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    double _value = LuaAPI.lua_tonumber(L, 3);
                    int _precision = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.Insert( _index, _value, _precision );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<object>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    object _value = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    string _value = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<char[]>(L, 3)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    char[] _value = (char[])translator.GetObject(L, 3, typeof(char[]));
                    
                    gen_to_be_invoked.Insert( _index, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    string _value = LuaAPI.lua_tostring(L, 3);
                    int _count = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.Insert( _index, _value, _count );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<char[]>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    char[] _value = (char[])translator.GetObject(L, 3, typeof(char[]));
                    int _startIndex = LuaAPI.xlua_tointeger(L, 4);
                    int _charCount = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.Insert( _index, _value, _startIndex, _charCount );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to CustomDataStruct.BetterStringBuilder.Insert!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _startIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _length = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Remove( _startIndex, _length );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Replace(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    char _oldChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    char _newChar = (char)LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.Replace( _oldChar, _newChar );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    char _oldChar = (char)LuaAPI.xlua_tointeger(L, 2);
                    char _newChar = (char)LuaAPI.xlua_tointeger(L, 3);
                    int _startIndex = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.Replace( _oldChar, _newChar, _startIndex, _count );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string _oldValue = LuaAPI.lua_tostring(L, 2);
                    string _newValue = LuaAPI.lua_tostring(L, 3);
                    
                    gen_to_be_invoked.Replace( _oldValue, _newValue );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _oldValue = LuaAPI.lua_tostring(L, 2);
                    string _newValue = LuaAPI.lua_tostring(L, 3);
                    int _startIndex = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.Replace( _oldValue, _newValue, _startIndex, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to CustomDataStruct.BetterStringBuilder.Replace!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToString(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                        var gen_ret = gen_to_be_invoked.ToString(  );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _startIndex = LuaAPI.xlua_tointeger(L, 2);
                    int _length = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.ToString( _startIndex, _length );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to CustomDataStruct.BetterStringBuilder.ToString!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToLower(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ToLower(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ToUpper(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ToUpper(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BufferSize(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.BufferSize);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Capacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Capacity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Length);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxCapacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.MaxCapacity);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Capacity(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Capacity = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Length(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                CustomDataStruct.BetterStringBuilder gen_to_be_invoked = (CustomDataStruct.BetterStringBuilder)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Length = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
