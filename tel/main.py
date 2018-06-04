from telethon import TelegramClient

api_id = 243010
api_hash = '0e3363e67ec1b0c3afea9e0a8b2adea9'

client = TelegramClient('session_name', api_id, api_hash)
client.start()
print("asd")
print(client.get_me().stringify())

client.send_message('@mandarinkov', 'Hello! Talking to you from Telethon')
messages = client.get_messages('@mandarinkov')
