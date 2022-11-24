using System.Reflection;



namespace __InterfaceProxies
{
	public class ServiceChannelProxy_UserDBServSoap : System.ServiceModel.Channels.ServiceChannelProxy_P, storageUniversal.UserDBServ.UserDBServSoap_P
	{
		System.Threading.Tasks.Task_P<string> storageUniversal.UserDBServ.UserDBServSoap_P.HelloWorldAsync()
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[0];
			System.Threading.Tasks.Task_P<string> retval = ((System.Threading.Tasks.Task_P<string>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.UserDBServ.UserDBServSoap_P.regAsync(storageUniversal.UserDBServ.User_P usr)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					usr
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.UserDBServ.UserDBServSoap_P.IsUserPermittedAsync(storageUniversal.UserDBServ.User_P usr)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					usr
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<int> storageUniversal.UserDBServ.UserDBServSoap_P.AddEmptyUserAsync()
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[0];
			System.Threading.Tasks.Task_P<int> retval = ((System.Threading.Tasks.Task_P<int>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<storageUniversal.UserDBServ.User_P> storageUniversal.UserDBServ.UserDBServSoap_P.GetFullUserAsync(storageUniversal.UserDBServ.User_P usr)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					usr
			};
			System.Threading.Tasks.Task_P<storageUniversal.UserDBServ.User_P> retval = ((System.Threading.Tasks.Task_P<storageUniversal.UserDBServ.User_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.UserDBServ.UserDBServSoap_P.updateUserByIdAsync(
					storageUniversal.UserDBServ.User_P OldUsr, 
					storageUniversal.UserDBServ.User_P NewUsr, 
					int id)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					OldUsr, 
					NewUsr, 
					id
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.UserDBServ.UserDBServSoap_P.updateUserByIdAdminAsync(
					int id, 
					storageUniversal.UserDBServ.User_P Admin, 
					storageUniversal.UserDBServ.User_P NewUsr)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					id, 
					Admin, 
					NewUsr
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.UserDBServ.UserDBServSoap_P.updateUserAsync(
					storageUniversal.UserDBServ.User_P OldUsr, 
					storageUniversal.UserDBServ.User_P NewUsr)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					OldUsr, 
					NewUsr
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.UserDBServ.UserDBServSoap_P.DeleteUserAsync(storageUniversal.UserDBServ.User_P usr)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					usr
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.UserDBServ.UserDBServSoap_P.DeleteUserAdminAsync(
					storageUniversal.UserDBServ.User_P Admin, 
					int id)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					Admin, 
					id
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.UserDBServ.UserDBServSoap_P.IsAdminAsync(storageUniversal.UserDBServ.User_P user)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					user
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<storageUniversal.UserDBServ.GetAdminUserTblResponseGetAdminUserTblResult_P> storageUniversal.UserDBServ.UserDBServSoap_P.GetAdminUserTblAsync(storageUniversal.UserDBServ.User_P user)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					user
			};
			System.Threading.Tasks.Task_P<storageUniversal.UserDBServ.GetAdminUserTblResponseGetAdminUserTblResult_P> retval = ((System.Threading.Tasks.Task_P<storageUniversal.UserDBServ.GetAdminUserTblResponseGetAdminUserTblResult_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}
	}

	public class ServiceChannelProxy_InventoryFuncsSoap : System.ServiceModel.Channels.ServiceChannelProxy_P, storageUniversal.InventoryServ.InventoryFuncsSoap_P
	{
		System.Threading.Tasks.Task_P<string> storageUniversal.InventoryServ.InventoryFuncsSoap_P.HelloWorldAsync()
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.InventoryServ.InventoryFuncsSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[0];
			System.Threading.Tasks.Task_P<string> retval = ((System.Threading.Tasks.Task_P<string>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<storageUniversal.InventoryServ.GetInventoryDataTableResponseGetInventoryDataTableResult_P> storageUniversal.InventoryServ.InventoryFuncsSoap_P.GetInventoryDataTableAsync()
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.InventoryServ.InventoryFuncsSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[0];
			System.Threading.Tasks.Task_P<storageUniversal.InventoryServ.GetInventoryDataTableResponseGetInventoryDataTableResult_P> retval = ((System.Threading.Tasks.Task_P<storageUniversal.InventoryServ.GetInventoryDataTableResponseGetInventoryDataTableResult_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<storageUniversal.InventoryServ.GetInventoryUserDataTableResponseGetInventoryUserDataTableResult_P> storageUniversal.InventoryServ.InventoryFuncsSoap_P.GetInventoryUserDataTableAsync(int userId)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.InventoryServ.InventoryFuncsSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					userId
			};
			System.Threading.Tasks.Task_P<storageUniversal.InventoryServ.GetInventoryUserDataTableResponseGetInventoryUserDataTableResult_P> retval = ((System.Threading.Tasks.Task_P<storageUniversal.InventoryServ.GetInventoryUserDataTableResponseGetInventoryUserDataTableResult_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.InventoryServ.InventoryFuncsSoap_P.changeInventoryRowAsync(storageUniversal.InventoryServ.InventoryRow_P inventoryRow)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.InventoryServ.InventoryFuncsSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					inventoryRow
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<bool> storageUniversal.InventoryServ.InventoryFuncsSoap_P.DeleteInventoryRowAsync(int id)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.InventoryServ.InventoryFuncsSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					id
			};
			System.Threading.Tasks.Task_P<bool> retval = ((System.Threading.Tasks.Task_P<bool>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<int> storageUniversal.InventoryServ.InventoryFuncsSoap_P.getNewItemIdAsync(int UserId)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.InventoryServ.InventoryFuncsSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					UserId
			};
			System.Threading.Tasks.Task_P<int> retval = ((System.Threading.Tasks.Task_P<int>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}
	}

	public class ServiceChannelProxy_BorowwingsDBSoap : System.ServiceModel.Channels.ServiceChannelProxy_P, storageUniversal.BorowwDb.BorowwingsDBSoap_P
	{
		System.Threading.Tasks.Task_P<storageUniversal.BorowwDb.HelloWorldResponse_P> storageUniversal.BorowwDb.BorowwingsDBSoap_P.HelloWorldAsync(storageUniversal.BorowwDb.HelloWorldRequest_P request)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.BorowwDb.BorowwingsDBSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					request
			};
			System.Threading.Tasks.Task_P<storageUniversal.BorowwDb.HelloWorldResponse_P> retval = ((System.Threading.Tasks.Task_P<storageUniversal.BorowwDb.HelloWorldResponse_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}

		System.Threading.Tasks.Task_P<storageUniversal.BorowwDb.AddLendingResponse_P> storageUniversal.BorowwDb.BorowwingsDBSoap_P.AddLendingAsync(storageUniversal.BorowwDb.AddLendingRequest_P request)
		{
			global::System.RuntimeMethodHandle interfaceMethod = global::System.Reflection.DispatchProxyHelpers.GetCorrespondingInterfaceMethodFromMethodImpl();
			global::System.RuntimeTypeHandle interfaceType = typeof(storageUniversal.BorowwDb.BorowwingsDBSoap_P).TypeHandle;
			global::System.Reflection.MethodBase targetMethodInfo = global::System.Reflection.MethodBase.GetMethodFromHandle(
								interfaceMethod, 
								interfaceType
							);
			object[] callsiteArgs = new object[] {
					request
			};
			System.Threading.Tasks.Task_P<storageUniversal.BorowwDb.AddLendingResponse_P> retval = ((System.Threading.Tasks.Task_P<storageUniversal.BorowwDb.AddLendingResponse_P>)base.Invoke(
								((global::System.Reflection.MethodInfo)targetMethodInfo), 
								callsiteArgs
							));
			return retval;
		}
	}

	[global::System.Runtime.CompilerServices.ModuleConstructor]
	[global::System.Runtime.CompilerServices.DependencyReductionRoot]
	public static class __DispatchProxyImplementationData
	{
		static global::System.Reflection.DispatchProxyEntry[] s_entryTable = new global::System.Reflection.DispatchProxyEntry[] {
				new global::System.Reflection.DispatchProxyEntry() {
					ProxyClassType = typeof(System.ServiceModel.Channels.ServiceChannelProxy_P).TypeHandle,
					InterfaceType = typeof(storageUniversal.UserDBServ.UserDBServSoap_P).TypeHandle,
					ImplementationClassType = typeof(ServiceChannelProxy_UserDBServSoap).TypeHandle,
				}, 
				new global::System.Reflection.DispatchProxyEntry() {
					ProxyClassType = typeof(System.ServiceModel.Channels.ServiceChannelProxy_P).TypeHandle,
					InterfaceType = typeof(storageUniversal.InventoryServ.InventoryFuncsSoap_P).TypeHandle,
					ImplementationClassType = typeof(ServiceChannelProxy_InventoryFuncsSoap).TypeHandle,
				}, 
				new global::System.Reflection.DispatchProxyEntry() {
					ProxyClassType = typeof(System.ServiceModel.Channels.ServiceChannelProxy_P).TypeHandle,
					InterfaceType = typeof(storageUniversal.BorowwDb.BorowwingsDBSoap_P).TypeHandle,
					ImplementationClassType = typeof(ServiceChannelProxy_BorowwingsDBSoap).TypeHandle,
				}
		};
		static __DispatchProxyImplementationData()
		{
			global::System.Reflection.DispatchProxyHelpers.RegisterImplementations(s_entryTable);
		}
	}
}

namespace storageUniversal.UserDBServ
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.UserDBServ.UserDBServSoap, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
		"ull")]
	public interface UserDBServSoap_P
	{
		System.Threading.Tasks.Task_P<string> HelloWorldAsync();

		System.Threading.Tasks.Task_P<bool> regAsync(User_P usr);

		System.Threading.Tasks.Task_P<bool> IsUserPermittedAsync(User_P usr);

		System.Threading.Tasks.Task_P<int> AddEmptyUserAsync();

		System.Threading.Tasks.Task_P<User_P> GetFullUserAsync(User_P usr);

		System.Threading.Tasks.Task_P<bool> updateUserByIdAsync(
					User_P OldUsr, 
					User_P NewUsr, 
					int id);

		System.Threading.Tasks.Task_P<bool> updateUserByIdAdminAsync(
					int id, 
					User_P Admin, 
					User_P NewUsr);

		System.Threading.Tasks.Task_P<bool> updateUserAsync(
					User_P OldUsr, 
					User_P NewUsr);

		System.Threading.Tasks.Task_P<bool> DeleteUserAsync(User_P usr);

		System.Threading.Tasks.Task_P<bool> DeleteUserAdminAsync(
					User_P Admin, 
					int id);

		System.Threading.Tasks.Task_P<bool> IsAdminAsync(User_P user);

		System.Threading.Tasks.Task_P<GetAdminUserTblResponseGetAdminUserTblResult_P> GetAdminUserTblAsync(User_P user);
	}
}

namespace System.ServiceModel.Channels
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.ServiceModel.Channels.ServiceChannelProxy, System.Private.ServiceModel, Version=4.5.0.4, Culture=neutral," +
		" PublicKeyToken=b03f5f7f11d50a3a")]
	public class ServiceChannelProxy_P : global::System.Reflection.DispatchProxy
	{
		protected override object Invoke(
					global::System.Reflection.MethodInfo targetMethodInfo, 
					object[] args)
		{
			return null;
		}
	}
}

namespace System.Reflection
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Reflection.DispatchProxy, System.Private.Interop, Version=999.999.999.999, Culture=neutral, PublicKeyToke" +
		"n=b03f5f7f11d50a3a")]
	public class DispatchProxy_P
	{
	}
}

namespace System.Threading.Tasks
{
	[global::System.Runtime.InteropServices.McgRedirectedType("System.Threading.Tasks.Task`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
		"11d50a3a")]
	public class Task_P<TResult>
	{
	}
}

namespace storageUniversal.UserDBServ
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.UserDBServ.User, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class User_P
	{
	}
}

namespace storageUniversal.UserDBServ
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.UserDBServ.GetAdminUserTblResponseGetAdminUserTblResult, storageUniversal, Version=1.0.0.0, Cul" +
		"ture=neutral, PublicKeyToken=null")]
	public class GetAdminUserTblResponseGetAdminUserTblResult_P
	{
	}
}

namespace storageUniversal.InventoryServ
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.InventoryServ.InventoryFuncsSoap, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKey" +
		"Token=null")]
	public interface InventoryFuncsSoap_P
	{
		System.Threading.Tasks.Task_P<string> HelloWorldAsync();

		System.Threading.Tasks.Task_P<GetInventoryDataTableResponseGetInventoryDataTableResult_P> GetInventoryDataTableAsync();

		System.Threading.Tasks.Task_P<GetInventoryUserDataTableResponseGetInventoryUserDataTableResult_P> GetInventoryUserDataTableAsync(int userId);

		System.Threading.Tasks.Task_P<bool> changeInventoryRowAsync(InventoryRow_P inventoryRow);

		System.Threading.Tasks.Task_P<bool> DeleteInventoryRowAsync(int id);

		System.Threading.Tasks.Task_P<int> getNewItemIdAsync(int UserId);
	}
}

namespace storageUniversal.InventoryServ
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.InventoryServ.GetInventoryDataTableResponseGetInventoryDataTableResult, storageUniversal, Versi" +
		"on=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class GetInventoryDataTableResponseGetInventoryDataTableResult_P
	{
	}
}

namespace storageUniversal.InventoryServ
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.InventoryServ.GetInventoryUserDataTableResponseGetInventoryUserDataTableResult, storageUniversa" +
		"l, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
	public class GetInventoryUserDataTableResponseGetInventoryUserDataTableResult_P
	{
	}
}

namespace storageUniversal.InventoryServ
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.InventoryServ.InventoryRow, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
		"null")]
	public class InventoryRow_P
	{
	}
}

namespace storageUniversal.BorowwDb
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.BorowwDb.BorowwingsDBSoap, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=n" +
		"ull")]
	public interface BorowwingsDBSoap_P
	{
		System.Threading.Tasks.Task_P<HelloWorldResponse_P> HelloWorldAsync(HelloWorldRequest_P request);

		System.Threading.Tasks.Task_P<AddLendingResponse_P> AddLendingAsync(AddLendingRequest_P request);
	}
}

namespace storageUniversal.BorowwDb
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.BorowwDb.HelloWorldResponse, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
		"=null")]
	public class HelloWorldResponse_P
	{
	}
}

namespace storageUniversal.BorowwDb
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.BorowwDb.HelloWorldRequest, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
		"null")]
	public class HelloWorldRequest_P
	{
	}
}

namespace storageUniversal.BorowwDb
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.BorowwDb.AddLendingResponse, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken" +
		"=null")]
	public class AddLendingResponse_P
	{
	}
}

namespace storageUniversal.BorowwDb
{
	[global::System.Runtime.InteropServices.McgRedirectedType("storageUniversal.BorowwDb.AddLendingRequest, storageUniversal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=" +
		"null")]
	public class AddLendingRequest_P
	{
	}
}
