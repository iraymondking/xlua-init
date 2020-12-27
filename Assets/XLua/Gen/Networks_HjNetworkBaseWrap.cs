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
    public class NetworksHjNetworkBaseWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(Networks.HjNetworkBase);
			Utils.BeginObjectRegister(type, L, translator, 0, 9, 4, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetHostPort", _m_SetHostPort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Connect", _m_Connect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StartAllThread", _m_StartAllThread);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "StopAllThread", _m_StopAllThread);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", _m_Close);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UpdateNetwork", _m_UpdateNetwork);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessage", _m_SendMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsConnect", _m_IsConnect);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ClientSocket", _g_get_ClientSocket);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnConnect", _g_get_OnConnect);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnClosed", _g_get_OnClosed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ReceivePkgHandle", _g_get_ReceivePkgHandle);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnConnect", _s_set_OnConnect);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnClosed", _s_set_OnClosed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ReceivePkgHandle", _s_set_ReceivePkgHandle);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "Networks.HjNetworkBase does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetHostPort(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _ip = LuaAPI.lua_tostring(L, 2);
                    int _port = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetHostPort( _ip, _port );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Connect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Connect(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StartAllThread(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.StartAllThread(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StopAllThread(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.StopAllThread(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Close(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Close(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateNetwork(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UpdateNetwork(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendMessage(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    byte[] _msgObj = LuaAPI.lua_tobytes(L, 2);
                    
                    gen_to_be_invoked.SendMessage( _msgObj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsConnect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.IsConnect(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ClientSocket(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ClientSocket);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnConnect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnConnect);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnClosed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.OnClosed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ReceivePkgHandle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ReceivePkgHandle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnConnect(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnConnect = translator.GetDelegate<System.Action<object, int, string>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnClosed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.OnClosed = translator.GetDelegate<System.Action<object, int, string>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ReceivePkgHandle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                Networks.HjNetworkBase gen_to_be_invoked = (Networks.HjNetworkBase)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ReceivePkgHandle = translator.GetDelegate<System.Action<byte[]>>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
