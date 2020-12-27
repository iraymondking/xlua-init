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
    public class ESocketErrorWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ESocketError);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 7, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NORMAL", ESocketError.NORMAL);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERROR_1", ESocketError.ERROR_1);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERROR_2", ESocketError.ERROR_2);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERROR_3", ESocketError.ERROR_3);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERROR_4", ESocketError.ERROR_4);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ERROR_5", ESocketError.ERROR_5);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				
				if (LuaAPI.lua_gettop(L) == 1)
				{
				    translator.Push(L, default(ESocketError));
			        return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ESocketError constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
