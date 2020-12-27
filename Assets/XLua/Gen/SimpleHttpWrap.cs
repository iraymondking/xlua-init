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
    public class SimpleHttpWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(SimpleHttp);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartHttp", _m_StartHttp);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 1, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "HttpGet", _m_HttpGet_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HttpPost", _m_HttpPost_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "newInstance", _g_get_newInstance);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new SimpleHttp();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to SimpleHttp constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HttpGet_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.Dictionary<string, string>>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.WWW>>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.Dictionary<string, string> _formData = (System.Collections.Generic.Dictionary<string, string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, string>));
                    byte[] _byteData = LuaAPI.lua_tobytes(L, 3);
                    System.Action<UnityEngine.WWW> _callback = translator.GetDelegate<System.Action<UnityEngine.WWW>>(L, 4);
                    float _timeOut = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    SimpleHttp.HttpGet( _url, _formData, _byteData, _callback, _timeOut );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.Dictionary<string, string>>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.WWW>>(L, 4)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.Dictionary<string, string> _formData = (System.Collections.Generic.Dictionary<string, string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, string>));
                    byte[] _byteData = LuaAPI.lua_tobytes(L, 3);
                    System.Action<UnityEngine.WWW> _callback = translator.GetDelegate<System.Action<UnityEngine.WWW>>(L, 4);
                    
                    SimpleHttp.HttpGet( _url, _formData, _byteData, _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to SimpleHttp.HttpGet!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HttpPost_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.Dictionary<string, string>>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.WWW>>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.Dictionary<string, string> _formData = (System.Collections.Generic.Dictionary<string, string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, string>));
                    byte[] _byteData = LuaAPI.lua_tobytes(L, 3);
                    System.Action<UnityEngine.WWW> _callback = translator.GetDelegate<System.Action<UnityEngine.WWW>>(L, 4);
                    float _timeOut = (float)LuaAPI.lua_tonumber(L, 5);
                    
                    SimpleHttp.HttpPost( _url, _formData, _byteData, _callback, _timeOut );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.Dictionary<string, string>>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action<UnityEngine.WWW>>(L, 4)) 
                {
                    string _url = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.Dictionary<string, string> _formData = (System.Collections.Generic.Dictionary<string, string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, string>));
                    byte[] _byteData = LuaAPI.lua_tobytes(L, 3);
                    System.Action<UnityEngine.WWW> _callback = translator.GetDelegate<System.Action<UnityEngine.WWW>>(L, 4);
                    
                    SimpleHttp.HttpPost( _url, _formData, _byteData, _callback );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to SimpleHttp.HttpPost!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartHttp(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                SimpleHttp gen_to_be_invoked = (SimpleHttp)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    HttpInfo _info = (HttpInfo)translator.GetObject(L, 2, typeof(HttpInfo));
                    
                    gen_to_be_invoked.StartHttp( _info );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_newInstance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, SimpleHttp.newInstance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
