from django import forms

class ImageForm(forms.Form):
    your_image = forms.CharField(label='이미지를 만드세요 ', max_length=500)