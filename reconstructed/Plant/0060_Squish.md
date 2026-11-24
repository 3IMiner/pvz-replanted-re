# System.Void Squish()

- 类：`Plant`
- 汇编行数：211

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	cmp byte ptr [184EEB646h],0
	mov rbx,rcx
	jne short 00000001806B5CF5h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	mov byte ptr [184EEB646h],1
	cmp dword ptr [rbx+70h],11h
	jne short 00000001806B5D16h
	cmp dword ptr [rbx+88h],5
	je short 00000001806B5D6Dh
	cmp dword ptr [rbx+88h],6
	je short 00000001806B5D6Dh
	cmp dword ptr [rbx+88h],7
	je short 00000001806B5D6Dh
	cmp byte ptr [rbx+3Ch],0
	jne short 00000001806B5D6Dh
	cmp dword ptr [rbx+128h],2
	je short 00000001806B5D6Dh
	cmp byte ptr [rbx+135h],0
	jne short 00000001806B5D6Dh
	cmp byte ptr [rbx+136h],0
	jne short 00000001806B5D73h
	cmp dword ptr [rbx+70h],2
	je short 00000001806B5D5Eh
	cmp dword ptr [rbx+70h],14h
	je short 00000001806B5D5Eh
	cmp dword ptr [rbx+70h],0Fh
	je short 00000001806B5D5Eh
	cmp dword ptr [rbx+70h],0Eh
	je short 00000001806B5D5Eh
	cmp dword ptr [rbx+70h],4
	jne short 00000001806B5D73h
	cmp dword ptr [rbx+88h],0
	je short 00000001806B5D73h
	xor edx,edx
	mov rcx,rbx
	add rsp,20h
	pop rbx
	jmp near ptr 00000001806AD780h
	add rsp,20h
	pop rbx
	ret
	cmp dword ptr [rbx+70h],11h
	jne short 00000001806B5D82h
	cmp dword ptr [rbx+88h],0
	jne short 00000001806B5D6Dh
	mov edx,[rbx+34h]
	xor r9d,r9d
	mov r8d,8
	mov ecx,497C8h
	call 0000000180665070h
	mov r8,[rbx+10h]
	mov [rbx+38h],eax
	mov byte ptr [rbx+3Ch],1
	mov dword ptr [rbx+98h],1F4h
	test r8,r8
	je near ptr 00000001806B5E48h
	mov r8,[r8+58h]
	test r8,r8
	je near ptr 00000001806B5E48h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,15h
	call 0000000180002040h
	xor edx,edx
	mov rcx,rbx
	call 00000001806B4E30h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je short 00000001806B5E48h
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	call 000000018065E170h
	test rax,rax
	je short 00000001806B5E0Bh
	xor edx,edx
	mov rcx,rax
	call 00000001806C2390h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B5E48h
	xor edx,edx
	call 00000001807DF5D0h
	test al,al
	je near ptr 00000001806B5D6Dh
	mov rax,[rbx+18h]
	test rax,rax
	je short 00000001806B5E48h
	mov rcx,[rax+110h]
	test rcx,rcx
	je short 00000001806B5E48h
	xor r8d,r8d
	mov rdx,rbx
	add rsp,20h
	pop rbx
	jmp near ptr 0000000180683A60h
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -32
	004 Compare [0x184EEB646], 0
	005 Move rbx, rcx
	006 JumpIfNotEqual {10}
	007 LoadAddress rcx, [0x184C75168]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 Move [0x184EEB646], 1
	010 Compare [rbx+112], 17
	011 JumpIfNotEqual {18}
	012 Compare [rbx+136], 5
	013 JumpIfEqual {45}
	014 Compare [rbx+136], 6
	015 JumpIfEqual {45}
	016 Compare [rbx+136], 7
	017 JumpIfEqual {45}
	018 Compare [rbx+60], 0
	019 JumpIfNotEqual {45}
	020 Compare [rbx+296], 2
	021 JumpIfEqual {45}
	022 Compare [rbx+309], 0
	023 JumpIfNotEqual {45}
	024 Compare [rbx+310], 0
	025 JumpIfNotEqual {49}
	026 Compare [rbx+112], 2
	027 JumpIfEqual {38}
	028 Compare [rbx+112], 20
	029 JumpIfEqual {38}
	030 Compare [rbx+112], 15
	031 JumpIfEqual {38}
	032 Compare [rbx+112], 14
	033 JumpIfEqual {38}
	034 Compare [rbx+112], 4
	035 JumpIfNotEqual {49}
	036 Compare [rbx+136], 0
	037 JumpIfEqual {49}
	038 Move rdx, 0
	039 Move rcx, rbx
	040 ShiftStack 32
	041 Move rbx, stack:0x0
	042 ShiftStack 8
	043 Call Plant.DoSpecial, rcx, rdx
	044 Return 
	045 ShiftStack 32
	046 Move rbx, stack:0x0
	047 ShiftStack 8
	048 Return 
	049 Compare [rbx+112], 17
	050 JumpIfNotEqual {53}
	051 Compare [rbx+136], 0
	052 JumpIfNotEqual {45}
	053 Move rdx, [rbx+52]
	054 Move r9, 0
	055 Move r8, 8
	056 Move rcx, 0x497C8
	057 Call Board.MakeRenderOrder, rcx, rdx, r8, r9
	058 Move r8, [rbx+16]
	059 Move [rbx+56], rax
	060 Move [rbx+60], 1
	061 Move [rbx+152], 500
	062 Compare r8, 0
	063 JumpIfEqual {106}
	064 Move r8, [r8+88]
	065 Compare r8, 0
	066 JumpIfEqual {106}
	067 Move rdx, typeof(Reloaded.Services.IAudioService)
	068 Move rcx, 6
	069 Move r9, 21
	070 Call 0x180002040, rcx, rdx, r8, r9
	071 Move rdx, 0
	072 Move rcx, rbx
	073 Call Plant.RemoveEffects, rcx, rdx
	074 Move rcx, [rbx+24]
	075 Compare rcx, 0
	076 JumpIfEqual {106}
	077 Move r8, [rbx+52]
	078 Move r9, 0
	079 Move rdx, [rbx+116]
	080 Call Board.GetLadderAt, rcx, rdx, r8
	081 Compare rax, 0
	082 JumpIfEqual {86}
	083 Move rdx, 0
	084 Move rcx, rax
	085 Call GridItem.GridItemDie, rcx, rdx
	086 Move rcx, [rbx+16]
	087 Compare rcx, 0
	088 JumpIfEqual {106}
	089 Move rdx, 0
	090 Call GameplayActivity.IsIZombieLevel, rcx, rdx
	091 Compare rax, 0
	092 JumpIfEqual {45}
	093 Move rax, [rbx+24]
	094 Compare rax, 0
	095 JumpIfEqual {106}
	096 Move rcx, [rax+272]
	097 Compare rcx, 0
	098 JumpIfEqual {106}
	099 Move r8, 0
	100 Move rdx, rbx
	101 ShiftStack 32
	102 Move rbx, stack:0x0
	103 ShiftStack 8
	104 Call Challenge.IZombiePlantDropRemainingSun, rcx, rdx
	105 Return 
	106 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
