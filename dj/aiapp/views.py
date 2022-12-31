import replicate
import os
from django.http import HttpResponseRedirect, HttpResponse
from django.shortcuts import render
from .forms import ImageForm

# Create your views here.

def index(request):
    if request.method == 'POST':
        form = ImageForm(request.POST)

        if form.is_valid():
            os.environ["REPLICATE_API_TOKEN"] = "d5dd536f89b8b1b77b4dc9ed402ec03634f5e513"
            model = replicate.models.get("stability-ai/stable-diffusion")
            version = model.versions.get("f178fa7a1ae43a9a9af01b833b9d2ecf97b1bcb0acfd2dc5dd04895e042863f1")

            image_url = version.predict(prompt=request.POST.get("your_image"))

            return HttpResponseRedirect("/your_image?image=" + image_url[0])
    else:
        form = ImageForm()

    return render(request, 'aiapp/index.html', {'form': form})

def your_image(request):
    return render(request, 'aiapp/your_image.html')