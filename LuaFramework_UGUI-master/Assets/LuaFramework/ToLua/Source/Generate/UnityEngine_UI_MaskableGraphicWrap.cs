//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_UI_MaskableGraphicWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.UI.MaskableGraphic), typeof(UnityEngine.UI.Graphic));
		L.RegFunction("ParentMaskStateChanged", ParentMaskStateChanged);
		L.RegFunction("SetMaterialDirty", SetMaterialDirty);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("maskable", get_maskable, set_maskable);
		L.RegVar("material", get_material, set_material);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ParentMaskStateChanged(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)ToLua.CheckObject<UnityEngine.UI.MaskableGraphic>(L, 1);
			obj.ParentMaskStateChanged();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetMaterialDirty(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)ToLua.CheckObject<UnityEngine.UI.MaskableGraphic>(L, 1);
			obj.SetMaterialDirty();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maskable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;
			bool ret = obj.maskable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maskable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_material(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;
			UnityEngine.Material ret = obj.material;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index material on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maskable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.maskable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maskable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_material(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.UI.MaskableGraphic obj = (UnityEngine.UI.MaskableGraphic)o;
			UnityEngine.Material arg0 = (UnityEngine.Material)ToLua.CheckObject<UnityEngine.Material>(L, 2);
			obj.material = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index material on a nil value");
		}
	}
}

