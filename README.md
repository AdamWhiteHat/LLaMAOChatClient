# LLaMAOChatClient

## What is it?

This application is a chatroom-like (winforms) GUI client to a local-running Large Language Model (LLM) AI assistant running in 'chat-bot mode'. 
Using Mocrosoft's Semantic Kernel library (which is in prerelease/preview at the time of writing this) to call a local-running instance of Ollama's API, which hosts the AI model. 



Because it uses Semantic Kernel, theoretically it could interface with models from AzureOpenAI, OpenAI, Mistral, Google, Hugging Face, Anthropic, Amazon Bedrock, or ONNX. Because Semantic Kernel doesnt support querying the installation  or running status of Ollama or other locally ran model servers (from what I can tell), and because I wanted to build in checks for this with helpful error messages, parts of the application are closely coupled with Ollama-specific installation artifacts (but these concerns are confined to a single class, so all the rest of the code is reusable).

## Requirements 
You will need:
- A GPU capable of running CUDA
- 5 to 500 GB of disk storage space (depending on the AI model you choose) for downloading the 

## Prerequisites

Before attempting to run this application, you will need to download the Ollama server, run it and pull down a model (although if you forget to do any of this, the application will helpfully tell you what is missing):
[https://ollama.com/download](https://ollama.com/download)



## AI Models

There is a large selection of AI models to choose from:
[https://ollama.com/search](https://ollama.com/search)

