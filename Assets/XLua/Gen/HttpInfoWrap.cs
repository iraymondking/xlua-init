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
    public class HttpInfoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(HttpInfo);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 6, 6);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "url", _g_get_url);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "type", _g_get_type);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "formData", _g_get_formData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "byteData", _g_get_byteData);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "timeOut", _g_get_timeOut);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "callbackDel", _g_get_callbackDel);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "url", _s_set_url);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "type", _s_set_type);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "formData", _s_set_formData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "byteData", _s_set_byteData);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "timeOut", _s_set_timeOut);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "callbackDel", _s_set_callbackDel);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new HttpInfo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to HttpInfo constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_url(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.url);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_type(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                translator.PushHTTP_TYPE(L, gen_to_be_invoked.type);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_formData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.formData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_byteData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.byteData);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_timeOut(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.timeOut);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_callbackDel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.callbackDel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_url(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.url = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_type(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                HTTP_TYPE gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.type = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_formData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.formData = (System.Collections.Generic.Dictionary<string, string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, string>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_byteData(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.byteData = LuaAPI.lua_tobytes(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_timeOut(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.timeOut = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_callbackDel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                HttpInfo gen_to_be_invoked = (HttpInfo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.callbackDel = translator.GetDelegate<System.Action<UnityEngine.WWW>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
