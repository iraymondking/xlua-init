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
    public class CustomDataStructMemoryLeakDetecterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(CustomDataStruct.MemoryLeakDetecter);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IncreseInstance", _m_IncreseInstance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DecreseInstance", _m_DecreseInstance);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPooledObjectCount", _m_SetPooledObjectCount);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 4, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Add", _m_Add_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Remove", _m_Remove_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Cleanup", _m_Cleanup_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "CustomDataStruct.MemoryLeakDetecter does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Add_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _moduleName = LuaAPI.lua_tostring(L, 1);
                    int _usingLimit = LuaAPI.xlua_tointeger(L, 2);
                    int _poolLimit = LuaAPI.xlua_tointeger(L, 3);
                    int _checkPendingMS = LuaAPI.xlua_tointeger(L, 4);
                    
                        var gen_ret = CustomDataStruct.MemoryLeakDetecter.Add( _moduleName, _usingLimit, _poolLimit, _checkPendingMS );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _moduleName = LuaAPI.lua_tostring(L, 1);
                    int _usingLimit = LuaAPI.xlua_tointeger(L, 2);
                    int _poolLimit = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = CustomDataStruct.MemoryLeakDetecter.Add( _moduleName, _usingLimit, _poolLimit );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    string _moduleName = LuaAPI.lua_tostring(L, 1);
                    int _usingLimit = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = CustomDataStruct.MemoryLeakDetecter.Add( _moduleName, _usingLimit );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _moduleName = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = CustomDataStruct.MemoryLeakDetecter.Add( _moduleName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to CustomDataStruct.MemoryLeakDetecter.Add!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Remove_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    CustomDataStruct.MemoryLeakDetecter _detecter = (CustomDataStruct.MemoryLeakDetecter)translator.GetObject(L, 1, typeof(CustomDataStruct.MemoryLeakDetecter));
                    
                    CustomDataStruct.MemoryLeakDetecter.Remove( _detecter );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IncreseInstance(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.MemoryLeakDetecter gen_to_be_invoked = (CustomDataStruct.MemoryLeakDetecter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.IncreseInstance(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DecreseInstance(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.MemoryLeakDetecter gen_to_be_invoked = (CustomDataStruct.MemoryLeakDetecter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.DecreseInstance(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPooledObjectCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                CustomDataStruct.MemoryLeakDetecter gen_to_be_invoked = (CustomDataStruct.MemoryLeakDetecter)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _count = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.SetPooledObjectCount( _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Cleanup_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    CustomDataStruct.MemoryLeakDetecter.Cleanup(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
