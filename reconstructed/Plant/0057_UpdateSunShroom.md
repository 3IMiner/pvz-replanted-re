# System.Void UpdateSunShroom()

- 类：`Plant`
- 汇编行数：208

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,30h
	cmp byte ptr [184EEB666h],0
	mov rbx,rcx
	jne short 00000001806BDAC9h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	lea rcx,[184C95150h]
	call 00000001804FEB70h
	lea rcx,[184C93218h]
	call 00000001804FEB70h
	mov byte ptr [184EEB666h],1
	cmp dword ptr [rbx+88h],17h
	mov [rsp+40h],rdi
	je near ptr 00000001806BDB73h
	cmp dword ptr [rbx+88h],18h
	jne near ptr 00000001806BDC5Ah
	mov rcx,[rbx+140h]
	test rcx,rcx
	je near ptr 00000001806BDC6Fh
	xor r8d,r8d
	xor edx,edx
	call 00000001807C7A30h
	test eax,eax
	jle near ptr 00000001806BDC64h
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BDB1Fh
	call 00000001804FEEB0h
	movss xmm1,dword ptr [183C33DB8h]
	xor r8d,r8d
	movss xmm0,dword ptr [183C33DB4h]
	call 00000001806CBD40h
	mov rdx,[184C93218h]
	mov r9d,0Ah
	xor r8d,r8d
	mov qword ptr [rsp+28h],0
	mov rcx,rbx
	movss dword ptr [rsp+20h],xmm0
	call 00000001806B4B80h
	mov dword ptr [rbx+88h],19h
	mov rdi,[rsp+40h]
	add rsp,30h
	pop rbx
	ret
	cmp dword ptr [rbx+0A0h],0
	jne near ptr 00000001806BDC5Ah
	cmp byte ptr [184EEB658h],0
	mov rdi,[184C95150h]
	jne short 00000001806BDBAFh
	lea rcx,[184C92A80h]
	call 00000001804FEB70h
	lea rcx,[184C911F8h]
	call 00000001804FEB70h
	mov byte ptr [184EEB658h],1
	test rdi,rdi
	je near ptr 00000001806BDC6Fh
	mov r8,[184C911F8h]
	xor r9d,r9d
	mov rdx,[184C92A80h]
	mov rcx,rdi
	call 0000000182A24E50h
	mov rcx,[rbx+140h]
	mov rdi,rax
	test rcx,rcx
	je near ptr 00000001806BDC6Fh
	movss xmm1,dword ptr [183C33DACh]
	xor r9d,r9d
	xor r8d,r8d
	call 000000018060F880h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806BDC6Fh
	movss xmm3,dword ptr [183C33DB4h]
	xor r8d,r8d
	mov qword ptr [rsp+28h],0
	mov rdx,rdi
	mov dword ptr [rsp+20h],3
	call 00000001807C8270h
	mov r8,[rbx+10h]
	mov dword ptr [rbx+88h],18h
	test r8,r8
	je short 00000001806BDC6Fh
	mov r8,[r8+58h]
	test r8,r8
	je short 00000001806BDC6Fh
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,3Fh
	call 0000000180002040h
	xor edx,edx
	mov rcx,rbx
	call 00000001806BACD0h
	mov rdi,[rsp+40h]
	add rsp,30h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -48
	004 Compare [0x184EEB666], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {16}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C75168]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C95150]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C93218]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 Move [0x184EEB666], 1
	016 Compare [rbx+136], 23
	017 Move stack:0x40, rdi
	018 JumpIfEqual {50}
	019 Compare [rbx+136], 24
	020 JumpIfNotEqual {95}
	021 Move rcx, [rbx+320]
	022 Compare rcx, 0
	023 JumpIfEqual {103}
	024 Move r8, 0
	025 Move rdx, 0
	026 Call ReloadedCharacterController.GetLoopCount, rcx, rdx
	027 Compare rax, 0
	028 JumpIfLessOrEqual {98}
	029 Move rcx, typeof(Reloaded.Gameplay.Common)
	030 Compare [rcx+228], 0
	031 JumpIfNotEqual {33}
	032 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	033 Move xmm1, [0x183C33DB8]
	034 Move r8, 0
	035 Move xmm0, [0x183C33DB4]
	036 Call Common.RandRangeFloat, xmm0, xmm1, r8
	037 Move rdx, "anim_bigidle"
	038 Move r9, 10
	039 Move r8, 0
	040 Move stack:0x28, 0
	041 Move rcx, rbx
	042 Move stack:0x20, xmm0
	043 Call Plant.PlayBodyReanim, rcx, rdx, r8, xmm3, stack:0x0
	044 Move [rbx+136], 25
	045 Move rdi, stack:0x40
	046 ShiftStack 48
	047 Move rbx, stack:0x0
	048 ShiftStack 8
	049 Return 
	050 Compare [rbx+160], 0
	051 JumpIfNotEqual {95}
	052 Compare [0x184EEB658], 0
	053 Move rdi, "anim_grow"
	054 JumpIfNotEqual {60}
	055 LoadAddress rcx, [0x184C92A80]
	056 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	057 LoadAddress rcx, [0x184C911F8]
	058 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	059 Move [0x184EEB658], 1
	060 Compare rdi, 0
	061 JumpIfEqual {103}
	062 Move r8, ""
	063 Move r9, 0
	064 Move rdx, "anim_"
	065 Move rcx, rdi
	066 Call String.Replace, rcx, rdx, r8
	067 Move rcx, [rbx+320]
	068 Move rdi, rax
	069 Compare rcx, 0
	070 JumpIfEqual {103}
	071 Move xmm1, [0x183C33DAC]
	072 Move r9, 0
	073 Move r8, 0
	074 Call 0x18060F880, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	075 Move rcx, [rbx+320]
	076 Compare rcx, 0
	077 JumpIfEqual {103}
	078 Move xmm3, [0x183C33DB4]
	079 Move r8, 0
	080 Move stack:0x28, 0
	081 Move rdx, rdi
	082 Move stack:0x20, 3
	083 Call ReloadedCharacterController.PlayAnimationOnTrack, rcx, rdx, xmm2, r9, stack:0x0
	084 Move r8, [rbx+16]
	085 Move [rbx+136], 24
	086 Compare r8, 0
	087 JumpIfEqual {103}
	088 Move r8, [r8+88]
	089 Compare r8, 0
	090 JumpIfEqual {103}
	091 Move rdx, typeof(Reloaded.Services.IAudioService)
	092 Move rcx, 6
	093 Move r9, 63
	094 Call 0x180002040, rcx, rdx, r8, r9
	095 Move rdx, 0
	096 Move rcx, rbx
	097 Call Plant.UpdateProductionPlant, rcx, rdx
	098 Move rdi, stack:0x40
	099 ShiftStack 48
	100 Move rbx, stack:0x0
	101 ShiftStack 8
	102 Return 
	103 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
