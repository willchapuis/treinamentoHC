# Generated by Django 4.0.4 on 2022-05-02 18:21

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('veiculos', '0006_alter_fatura_observacoes'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='categoria',
            name='dt_criacao',
        ),
    ]
