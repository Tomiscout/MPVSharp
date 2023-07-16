using Nickvision.MPVSharp.Internal;

namespace Nickvision.MPVSharp;

/// <summary>
/// Args for GetPropertyReply event
/// </summary>
public class GetPropertyReplyReceivedEventArgs : EventArgs
{
    /// <summary>
    /// Reply userdata
    /// </summary>
    public ulong ReplyUserdata;
    /// <summary>
    /// Property name
    /// </summary>
    public string Name;
    /// <summary>
    /// MPVNode holding data
    /// </summary>
    public MPVNode? Node;

    /// <summary>
    /// Create args for GetPropertyReply event
    /// </summary>
    /// <param name="replyUserdata">Reply userdata</param>
    /// <param name="name">Property name</param>
    /// <param name="node">Node holding data</param>
    public GetPropertyReplyReceivedEventArgs(ulong replyUserdata, string name, MPVNode? node)
    {
        ReplyUserdata = replyUserdata;
        Name = name;
        Node = node;
    }
}