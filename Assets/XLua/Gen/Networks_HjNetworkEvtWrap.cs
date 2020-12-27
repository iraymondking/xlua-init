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
    public class NetworksHjNetworkEvtWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Networks.HjNetworkEvt);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 4, 4);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "sender", _g_get_sender);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "result", _g_get_result);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "msg", _g_get_msg);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "evtHandle", _g_get_evtHandle);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "sender", _s_set_sender);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "result", _s_set_result);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "msg", _s_set_msg);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "evtHandle", _s_set_evtHandle);
            
			
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
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<object>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && (LuaAPI.lua_isnil(L, 4) || LuaAPI.lua_type(L, 4) == LuaTypes.LUA_TSTRING) && translator.Assignable<System.Action<object, int, string>>(L, 5))
				{
					object _sender = translator.GetObject(L, 2, typeof(object));
					int _result = LuaAPI.xlua_tointeger(L, 3);
					string _msg = LuaAPI.lua_tostring(L, 4);
					System.Action<object, int, string> _evtHandle = translator.GetDelegate<System.Action<object, int, string>>(L, 5);
					
					var gen_ret = new Networks.HjNetworkEvt(_sender, _result, _msg, _evtHandle);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(Networks.HjNetworkEvt));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to Networks.HjNetworkEvt constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sender(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkEvt gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.PushAny(L, gen_to_be_invoked.sender);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_result(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkEvt gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.result);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_msg(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkEvt gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.msg);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_evtHandle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkEvt gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                translator.Push(L, gen_to_be_invoked.evtHandle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_sender(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkEvt gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.sender = translator.GetObject(L, 2, typeof(object));
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_result(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkEvt gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.result = LuaAPI.xlua_tointeger(L, 2);
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_msg(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkEvt gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.msg = LuaAPI.lua_tostring(L, 2);
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_evtHandle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkEvt gen_to_be_invoked;translator.Get(L, 1, out gen_to_be_invoked);
                gen_to_be_invoked.evtHandle = translator.GetDelegate<System.Action<object, int, string>>(L, 2);
            
                translator.Update(L, 1, gen_to_be_invoked);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
