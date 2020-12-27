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
    public class XLuaMessengerExporterWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XLuaMessengerExporter);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 3, 3);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LuaCallCSharp", _g_get_LuaCallCSharp);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CSharpCallLua1", _g_get_CSharpCallLua1);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CSharpCallLua2", _g_get_CSharpCallLua2);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "LuaCallCSharp", _s_set_LuaCallCSharp);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CSharpCallLua1", _s_set_CSharpCallLua1);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "CSharpCallLua2", _s_set_CSharpCallLua2);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "XLuaMessengerExporter does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LuaCallCSharp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XLuaMessengerExporter.LuaCallCSharp);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CSharpCallLua1(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XLuaMessengerExporter.CSharpCallLua1);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CSharpCallLua2(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, XLuaMessengerExporter.CSharpCallLua2);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LuaCallCSharp(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    XLuaMessengerExporter.LuaCallCSharp = (System.Collections.Generic.List<System.Type>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<System.Type>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CSharpCallLua1(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    XLuaMessengerExporter.CSharpCallLua1 = (System.Collections.Generic.List<System.Type>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<System.Type>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CSharpCallLua2(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    XLuaMessengerExporter.CSharpCallLua2 = (System.Collections.Generic.List<System.Type>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<System.Type>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
