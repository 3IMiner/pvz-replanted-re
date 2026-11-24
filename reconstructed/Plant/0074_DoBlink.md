# System.Void DoBlink()

- 类：`Plant`
- 汇编行数：300

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB656h],0
	mov rbx,rcx
	jne short 00000001806AD2C1h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C94A90h]
	call 00000001804FEB70h
	lea rcx,[184C5E1C8h]
	call 00000001804FEB70h
	lea rcx,[184C3ED98h]
	call 00000001804FEB70h
	lea rcx,[184C95FA8h]
	call 00000001804FEB70h
	lea rcx,[184C5E7C8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB656h],1
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AD2D6h
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,190h
	call 00000001806CBE80h
	add eax,190h
	cmp dword ptr [rbx+70h],11h
	mov [rbx+0FCh],eax
	jne short 00000001806AD31Ah
	cmp dword ptr [rbx+88h],5
	je near ptr 00000001806AD496h
	cmp dword ptr [rbx+88h],6
	je near ptr 00000001806AD496h
	cmp dword ptr [rbx+88h],7
	je near ptr 00000001806AD496h
	cmp byte ptr [rbx+3Ch],0
	jne near ptr 00000001806AD496h
	cmp dword ptr [rbx+128h],2
	je near ptr 00000001806AD496h
	cmp byte ptr [rbx+135h],0
	jne near ptr 00000001806AD496h
	cmp dword ptr [rbx+0DCh],0
	jne near ptr 00000001806AD496h
	cmp dword ptr [rbx+70h],4
	jne short 00000001806AD35Eh
	cmp dword ptr [rbx+88h],10h
	jne near ptr 00000001806AD496h
	cmp dword ptr [rbx+88h],1Fh
	je near ptr 00000001806AD496h
	cmp dword ptr [rbx+88h],20h
	je near ptr 00000001806AD496h
	cmp dword ptr [rbx+88h],21h
	je near ptr 00000001806AD496h
	cmp dword ptr [rbx+88h],1Ah
	je near ptr 00000001806AD496h
	cmp dword ptr [rbx+88h],1Bh
	je near ptr 00000001806AD496h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AD50Eh
	xor edx,edx
	call 00000001807C7650h
	cmp dword ptr [rbx+70h],17h
	jne short 00000001806AD3F5h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AD50Eh
	mov rdx,[184C95FA8h]
	xor r8d,r8d
	call 00000001807C9B90h
	mov rdx,[184C5E7C8h]
	xor r8d,r8d
	mov rcx,rax
	call 0000000182A1F550h
	test al,al
	jne near ptr 00000001806AD496h
	cmp dword ptr [rbx+70h],24h
	jne short 00000001806AD430h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AD50Eh
	mov rdx,[184C94A90h]
	xor r8d,r8d
	call 00000001807C9B90h
	mov rdx,[184C5E1C8h]
	xor r8d,r8d
	mov rcx,rax
	call 0000000182A1F550h
	test al,al
	jne short 00000001806AD496h
	cmp dword ptr [rbx+70h],3
	je short 00000001806AD448h
	cmp dword ptr [rbx+70h],17h
	je short 00000001806AD448h
	cmp dword ptr [rbx+70h],31h
	je short 00000001806AD448h
	cmp dword ptr [rbx+70h],32h
	jne short 00000001806AD474h
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AD45Dh
	call 00000001804FEEB0h
	xor edx,edx
	mov ecx,3E8h
	call 00000001806CBE80h
	add eax,3E8h
	mov [rbx+0FCh],eax
	cmp dword ptr [rbx+70h],1Ch
	je short 00000001806AD49Ch
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806AD50Eh
	xor edx,edx
	add rsp,30h
	pop rbx
	jmp near ptr 00000001807C8340h
	add rsp,30h
	pop rbx
	ret
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AD4B1h
	call 00000001804FEEB0h
	xor r8d,r8d
	mov edx,1
	xor ecx,ecx
	call 00000001806CBDF0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806AD50Eh
	cmp eax,1
	je short 00000001806AD48Ah
	mov rcx,[rcx+158h]
	test rcx,rcx
	je short 00000001806AD50Eh
	movss xmm3,dword ptr [183C33DB4h]
	mov r8d,6
	mov rdx,[184C3ED98h]
	mov qword ptr [rsp+28h],0
	mov dword ptr [rsp+20h],2
	call 0000000180724A90h
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB656], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {20}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C94A90]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C5E1C8]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C3ED98]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C95FA8]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C5E7C8]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 Move [0x184EEB656], 1
	020 Move rcx, typeof(Reloaded.Gameplay.Common)
	021 Compare [rcx+228], 0
	022 JumpIfNotEqual {24}
	023 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	024 Move rdx, 0
	025 Move rcx, 400
	026 Call Common.Rand, rcx, rdx
	027 Add rax, rax, 400
	028 Compare [rbx+112], 17
	029 Move [rbx+252], rax
	030 JumpIfNotEqual {37}
	031 Compare [rbx+136], 5
	032 JumpIfEqual {120}
	033 Compare [rbx+136], 6
	034 JumpIfEqual {120}
	035 Compare [rbx+136], 7
	036 JumpIfEqual {120}
	037 Compare [rbx+60], 0
	038 JumpIfNotEqual {120}
	039 Compare [rbx+296], 2
	040 JumpIfEqual {120}
	041 Compare [rbx+309], 0
	042 JumpIfNotEqual {120}
	043 Compare [rbx+220], 0
	044 JumpIfNotEqual {120}
	045 Compare [rbx+112], 4
	046 JumpIfNotEqual {49}
	047 Compare [rbx+136], 16
	048 JumpIfNotEqual {120}
	049 Compare [rbx+136], 31
	050 JumpIfEqual {120}
	051 Compare [rbx+136], 32
	052 JumpIfEqual {120}
	053 Compare [rbx+136], 33
	054 JumpIfEqual {120}
	055 Compare [rbx+136], 26
	056 JumpIfEqual {120}
	057 Compare [rbx+136], 27
	058 JumpIfEqual {120}
	059 Move rcx, [rbx+320]
	060 Compare rcx, 0
	061 JumpIfEqual {150}
	062 Move rdx, 0
	063 Call ReloadedCharacterController.DisableBlink, rcx, rdx
	064 Compare [rbx+112], 23
	065 JumpIfNotEqual {78}
	066 Move rcx, [rbx+320]
	067 Compare rcx, 0
	068 JumpIfEqual {150}
	069 Move rdx, "anim_idle"
	070 Move r8, 0
	071 Call ReloadedController.GetImageOverride, rcx, rdx
	072 Move rdx, "IMAGE_REANIM_TALLNUT_CRACKED2"
	073 Move r8, 0
	074 Move rcx, rax
	075 Call 0x182A1F550, rcx, rdx, r8
	076 Compare rax, 0
	077 JumpIfNotEqual {120}
	078 Compare [rbx+112], 36
	079 JumpIfNotEqual {92}
	080 Move rcx, [rbx+320]
	081 Compare rcx, 0
	082 JumpIfEqual {150}
	083 Move rdx, "anim_face"
	084 Move r8, 0
	085 Call ReloadedController.GetImageOverride, rcx, rdx
	086 Move rdx, "IMAGE_REANIM_GARLIC_BODY3"
	087 Move r8, 0
	088 Move rcx, rax
	089 Call 0x182A1F550, rcx, rdx, r8
	090 Compare rax, 0
	091 JumpIfNotEqual {120}
	092 Compare [rbx+112], 3
	093 JumpIfEqual {100}
	094 Compare [rbx+112], 23
	095 JumpIfEqual {100}
	096 Compare [rbx+112], 49
	097 JumpIfEqual {100}
	098 Compare [rbx+112], 50
	099 JumpIfNotEqual {109}
	100 Move rcx, typeof(Reloaded.Gameplay.Common)
	101 Compare [rcx+228], 0
	102 JumpIfNotEqual {104}
	103 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	104 Move rdx, 0
	105 Move rcx, 1000
	106 Call Common.Rand, rcx, rdx
	107 Add rax, rax, 1000
	108 Move [rbx+252], rax
	109 Compare [rbx+112], 28
	110 JumpIfEqual {124}
	111 Move rcx, [rbx+320]
	112 Compare rcx, 0
	113 JumpIfEqual {150}
	114 Move rdx, 0
	115 ShiftStack 48
	116 Move rbx, stack:0x0
	117 ShiftStack 8
	118 Call ReloadedCharacterController.PlayBlink, rcx, rdx
	119 Return 
	120 ShiftStack 48
	121 Move rbx, stack:0x0
	122 ShiftStack 8
	123 Return 
	124 Move rcx, typeof(Reloaded.Gameplay.Common)
	125 Compare [rcx+228], 0
	126 JumpIfNotEqual {128}
	127 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	128 Move r8, 0
	129 Move rdx, 1
	130 Move rcx, 0
	131 Call Common.RandRangeInt, rcx, rdx, r8
	132 Move rcx, [rbx+320]
	133 Compare rcx, 0
	134 JumpIfEqual {150}
	135 Compare rax, 1
	136 JumpIfEqual {114}
	137 Move rcx, [rcx+344]
	138 Compare rcx, 0
	139 JumpIfEqual {150}
	140 Move xmm3, [0x183C33DB4]
	141 Move r8, 6
	142 Move rdx, "SplitPea_blink"
	143 Move stack:0x28, 0
	144 Move stack:0x20, 2
	145 Call CharacterAnimationController.PlayAnimation, rcx, rdx, xmm2, r9, stack:0x0
	146 ShiftStack 48
	147 Move rbx, stack:0x0
	148 ShiftStack 8
	149 Return 
	150 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
