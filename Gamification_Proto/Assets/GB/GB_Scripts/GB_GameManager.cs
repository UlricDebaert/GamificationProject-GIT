using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GB_GameManager : MonoBehaviour
{
    public string username;

    public int maxMessages = 10;

    public GameObject chatPanel, textObject;
    public TMP_InputField chatBox;

    public Color playerMessage, info;

    [SerializeField]
    List<Message> messageList = new List<Message>();
    void Start()
    {
        
    }
    void Update()
    {
        if(chatBox.text != null)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                SendMessageToChat(username + ": " + chatBox.text, Message.MessageType.playerMessage);
                chatBox.text = null;
            }
        }
        else
        {
            if (!chatBox.isFocused && Input.GetKeyDown(KeyCode.Return))
                chatBox.ActivateInputField();
        }
        if (!chatBox.isFocused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SendMessageToChat("Space Bar Pressed", Message.MessageType.info);
            }
        }
    }     
    public void SendMessageToChat(string text, Message.MessageType messageType)
    {
        //At max, remove first message each time another one is added to the list
        if (messageList.Count >= maxMessages)
        {
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }

        //Add message to the list and keep track of it
        Message newMessage = new Message();
        newMessage.text = text;

        GameObject newText = Instantiate(textObject, chatPanel.transform);

        newMessage.textObject = newText.GetComponent<TMP_Text>();

        newMessage.textObject.text = newMessage.text;
        newMessage.textObject.color = MessageTypeColor(messageType);

        messageList.Add(newMessage);
    }

    public void SendMessageClick()
    {
        SendMessageToChat(username + ": " + chatBox.text, Message.MessageType.playerMessage);
        chatBox.text = null;
    }


    Color MessageTypeColor(Message.MessageType messageType)
    {
        Color color = info;

        switch(messageType)
        {
            case Message.MessageType.playerMessage:
                color = playerMessage;
                break;
        }

        return color;
    }
}

[System.Serializable]
public class Message
{
    public string text;
    public TMP_Text textObject;
    public MessageType messageType;

    public enum MessageType
    {
        playerMessage,
        info
    }
}
