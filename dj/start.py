import replicate
import os

os.environ["REPLICATE_API_TOKEN"] = "d5dd536f89b8b1b77b4dc9ed402ec03634f5e513"
model = replicate.models.get("stability-ai/stable-diffusion")
version = model.versions.get("f178fa7a1ae43a9a9af01b833b9d2ecf97b1bcb0acfd2dc5dd04895e042863f1")

image_arg = input("만들거 쳐라\n")

print(version.predict(prompt=image_arg))