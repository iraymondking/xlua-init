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
    public class AssetBundlesAssetBundleConfigWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(AssetBundles.AssetBundleConfig);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 11, 5, 2);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "localSvrAppPath", AssetBundles.AssetBundleConfig.localSvrAppPath);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AssetBundlesFolderName", AssetBundles.AssetBundleConfig.AssetBundlesFolderName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AssetBundleSuffix", AssetBundles.AssetBundleConfig.AssetBundleSuffix);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AssetsFolderName", AssetBundles.AssetBundleConfig.AssetsFolderName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ChannelFolderName", AssetBundles.AssetBundleConfig.ChannelFolderName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AssetsPathMapFileName", AssetBundles.AssetBundleConfig.AssetsPathMapFileName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VariantsMapFileName", AssetBundles.AssetBundleConfig.VariantsMapFileName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "AssetBundleServerUrlFileName", AssetBundles.AssetBundleConfig.AssetBundleServerUrlFileName);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "VariantMapParttren", AssetBundles.AssetBundleConfig.VariantMapParttren);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CommonMapPattren", AssetBundles.AssetBundleConfig.CommonMapPattren);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "AssetBundlesBuildOutputPath", _g_get_AssetBundlesBuildOutputPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LocalSvrAppPath", _g_get_LocalSvrAppPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "LocalSvrAppWorkPath", _g_get_LocalSvrAppWorkPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsEditorMode", _g_get_IsEditorMode);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "IsSimulateMode", _g_get_IsSimulateMode);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "IsEditorMode", _s_set_IsEditorMode);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "IsSimulateMode", _s_set_IsSimulateMode);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new AssetBundles.AssetBundleConfig();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to AssetBundles.AssetBundleConfig constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AssetBundlesBuildOutputPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AssetBundles.AssetBundleConfig.AssetBundlesBuildOutputPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LocalSvrAppPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AssetBundles.AssetBundleConfig.LocalSvrAppPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LocalSvrAppWorkPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, AssetBundles.AssetBundleConfig.LocalSvrAppWorkPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsEditorMode(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, AssetBundles.AssetBundleConfig.IsEditorMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsSimulateMode(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushboolean(L, AssetBundles.AssetBundleConfig.IsSimulateMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsEditorMode(RealStatePtr L)
        {
		    try {
                
			    AssetBundles.AssetBundleConfig.IsEditorMode = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsSimulateMode(RealStatePtr L)
        {
		    try {
                
			    AssetBundles.AssetBundleConfig.IsSimulateMode = LuaAPI.lua_toboolean(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
