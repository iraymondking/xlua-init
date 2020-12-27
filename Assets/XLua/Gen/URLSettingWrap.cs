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
    public class URLSettingWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(URLSetting);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 7, 6);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "START_UP_URL", _g_get_START_UP_URL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "SERVER_RESOURCE_URL", _g_get_SERVER_RESOURCE_URL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "APP_DOWNLOAD_URL", _g_get_APP_DOWNLOAD_URL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LOGIN_URL", _g_get_LOGIN_URL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "REPORT_ERROR_URL", _g_get_REPORT_ERROR_URL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "SERVER_LIST_URL", _g_get_SERVER_LIST_URL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "NOTICE_URL", _g_get_NOTICE_URL);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "SERVER_RESOURCE_URL", _s_set_SERVER_RESOURCE_URL);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "APP_DOWNLOAD_URL", _s_set_APP_DOWNLOAD_URL);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LOGIN_URL", _s_set_LOGIN_URL);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "REPORT_ERROR_URL", _s_set_REPORT_ERROR_URL);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "SERVER_LIST_URL", _s_set_SERVER_LIST_URL);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "NOTICE_URL", _s_set_NOTICE_URL);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new URLSetting();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to URLSetting constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_START_UP_URL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, URLSetting.START_UP_URL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SERVER_RESOURCE_URL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, URLSetting.SERVER_RESOURCE_URL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_APP_DOWNLOAD_URL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, URLSetting.APP_DOWNLOAD_URL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LOGIN_URL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, URLSetting.LOGIN_URL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_REPORT_ERROR_URL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, URLSetting.REPORT_ERROR_URL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SERVER_LIST_URL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, URLSetting.SERVER_LIST_URL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_NOTICE_URL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, URLSetting.NOTICE_URL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SERVER_RESOURCE_URL(RealStatePtr L)
        {
		    try {
                
			    URLSetting.SERVER_RESOURCE_URL = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_APP_DOWNLOAD_URL(RealStatePtr L)
        {
		    try {
                
			    URLSetting.APP_DOWNLOAD_URL = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LOGIN_URL(RealStatePtr L)
        {
		    try {
                
			    URLSetting.LOGIN_URL = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_REPORT_ERROR_URL(RealStatePtr L)
        {
		    try {
                
			    URLSetting.REPORT_ERROR_URL = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_SERVER_LIST_URL(RealStatePtr L)
        {
		    try {
                
			    URLSetting.SERVER_LIST_URL = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_NOTICE_URL(RealStatePtr L)
        {
		    try {
                
			    URLSetting.NOTICE_URL = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
