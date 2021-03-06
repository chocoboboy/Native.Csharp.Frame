﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Native.Csharp.App.EventArgs;

namespace Native.Csharp.App.Interface
{
	/// <summary>
	/// Type=21 讨论组私聊消息, 事件接口
	/// </summary>
	public interface IReceiveDiscussPrivateMessage
	{
		/// <summary>
		/// 当在派生类中重写时, 处理收到的讨论组私聊消息
		/// </summary>
		/// <param name="sender">事件的触发对象</param>
		/// <param name="e">事件的附加参数</param>
		void ReceiveDiscussPrivateMessage (object sender, CqPrivateMessageEventArgs e);
	}
}
