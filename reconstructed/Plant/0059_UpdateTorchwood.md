# System.Void UpdateTorchwood()

- 类：`Plant`
- 汇编行数：209

## 反汇编

```asm

Disassembly:
	mov [rsp+10h],rsi
	push rdi
	sub rsp,50h
	cmp byte ptr [184EEB652h],0
	mov rdi,rcx
	jne short 00000001806BDFA1h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C7FBD8h]
	call 00000001804FEB70h
	lea rcx,[184C7FCB0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB652h],1
	xorps xmm0,xmm0
	mov [rsp+60h],rbx
	xorps xmm1,xmm1
	lea rcx,[rsp+40h]
	xor r9d,r9d
	xor r8d,r8d
	mov rdx,rdi
	movups [rsp+30h],xmm0
	movups [rsp+20h],xmm1
	call 00000001806B1660h
	xor esi,esi
	mov edx,esi
	movups xmm0,[rax]
	mov rax,[rdi+18h]
	movups [rsp+30h],xmm0
	test rax,rax
	je near ptr 00000001806BE106h
	nop dword ptr [rax]
	nop word ptr [rax+rax]
	mov rcx,[rax+80h]
	test rcx,rcx
	je near ptr 00000001806BE106h
	cmp edx,[rcx+28h]
	jge near ptr 00000001806BE0F6h
	mov rax,[rdi+18h]
	test rax,rax
	je near ptr 00000001806BE106h
	mov rcx,[rax+80h]
	test rcx,rcx
	je near ptr 00000001806BE106h
	mov r8,[184C7FCB0h]
	mov edx,esi
	call 0000000182449330h
	mov rbx,rax
	test rax,rax
	je near ptr 00000001806BE106h
	mov eax,[rdi+34h]
	cmp [rbx+34h],eax
	jne near ptr 00000001806BE0E4h
	cmp dword ptr [rbx+0A8h],0
	je short 00000001806BE067h
	cmp dword ptr [rbx+0A8h],0Eh
	je short 00000001806BE067h
	cmp dword ptr [rbx+0A8h],1
	jne short 00000001806BE0E4h
	xor r8d,r8d
	lea rcx,[rsp+40h]
	mov rdx,rbx
	call 00000001806C86F0h
	mov rcx,[184C2AFC0h]
	movups xmm0,[rax]
	movups [rsp+20h],xmm0
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806BE094h
	call 00000001804FEEB0h
	xor r8d,r8d
	lea rdx,[rsp+20h]
	lea rcx,[rsp+30h]
	call 00000001806CBAA0h
	cmp eax,0Ah
	jl short 00000001806BE0E4h
	cmp dword ptr [rbx+0A8h],0
	je short 00000001806BE0D6h
	cmp dword ptr [rbx+0A8h],0Eh
	je short 00000001806BE0D6h
	cmp dword ptr [rbx+0A8h],1
	jne short 00000001806BE0E4h
	mov edx,[rdi+74h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806C71E0h
	jmp short 00000001806BE0E4h
	mov edx,[rdi+74h]
	xor r8d,r8d
	mov rcx,rbx
	call 00000001806C6F60h
	mov rax,[rdi+18h]
	inc esi
	mov edx,esi
	test rax,rax
	je short 00000001806BE106h
	jmp near ptr 00000001806BDFF0h
	mov rbx,[rsp+60h]
	mov rsi,[rsp+68h]
	add rsp,50h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x10, rsi
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -80
	005 Compare [0x184EEB652], 0
	006 Move rdi, rcx
	007 JumpIfNotEqual {15}
	008 LoadAddress rcx, [0x184C2AFC0]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C7FBD8]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 LoadAddress rcx, [0x184C7FCB0]
	013 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	014 Move [0x184EEB652], 1
	015 Move xmm0, 0
	016 Move stack:0x60, rbx
	017 Move xmm1, 0
	018 LoadAddress rcx, stack:0x40
	019 Move r9, 0
	020 Move r8, 0
	021 Move rdx, rdi
	022 Move stack:0x30, xmm0
	023 Move stack:0x20, xmm1
	024 Call Plant.GetPlantAttackRect, rcx, rdx
	025 Move rsi, 0
	026 Move rdx, rsi
	027 Move xmm0, [rax]
	028 Move rax, [rdi+24]
	029 Move stack:0x30, xmm0
	030 Compare rax, 0
	031 JumpIfEqual {103}
	032 Nop 
	033 Nop 
	034 Move rcx, [rax+128]
	035 Compare rcx, 0
	036 JumpIfEqual {103}
	037 Compare rdx, [rcx+40]
	038 JumpIfGreaterOrEqual {97}
	039 Move rax, [rdi+24]
	040 Compare rax, 0
	041 JumpIfEqual {103}
	042 Move rcx, [rax+128]
	043 Compare rcx, 0
	044 JumpIfEqual {103}
	045 Move r8, [0x184C7FCB0]
	046 Move rdx, rsi
	047 Call 0x182449330, rcx, rdx
	048 Move rbx, rax
	049 Compare rax, 0
	050 JumpIfEqual {103}
	051 Move rax, [rdi+52]
	052 Compare [rbx+52], rax
	053 JumpIfNotEqual {91}
	054 Compare [rbx+168], 0
	055 JumpIfEqual {60}
	056 Compare [rbx+168], 14
	057 JumpIfEqual {60}
	058 Compare [rbx+168], 1
	059 JumpIfNotEqual {91}
	060 Move r8, 0
	061 LoadAddress rcx, stack:0x40
	062 Move rdx, rbx
	063 Call Projectile.GetProjectileRect, rcx, rdx
	064 Move rcx, typeof(Reloaded.Gameplay.Common)
	065 Move xmm0, [rax]
	066 Move stack:0x20, xmm0
	067 Compare [rcx+228], 0
	068 JumpIfNotEqual {70}
	069 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	070 Move r8, 0
	071 LoadAddress rdx, stack:0x20
	072 LoadAddress rcx, stack:0x30
	073 Call Common.GetRectOverlap, rcx, rdx, r8
	074 Compare rax, 10
	075 JumpIfLess {91}
	076 Compare [rbx+168], 0
	077 JumpIfEqual {87}
	078 Compare [rbx+168], 14
	079 JumpIfEqual {87}
	080 Compare [rbx+168], 1
	081 JumpIfNotEqual {91}
	082 Move rdx, [rdi+116]
	083 Move r8, 0
	084 Move rcx, rbx
	085 Call Projectile.ConvertToPea, rcx, rdx
	086 Goto {91}
	087 Move rdx, [rdi+116]
	088 Move r8, 0
	089 Move rcx, rbx
	090 Call Projectile.ConvertToFireball, rcx, rdx
	091 Move rax, [rdi+24]
	092 Add rsi, rsi, 1
	093 Move rdx, rsi
	094 Compare rax, 0
	095 JumpIfEqual {103}
	096 Goto {34}
	097 Move rbx, stack:0x60
	098 Move rsi, stack:0x68
	099 ShiftStack 80
	100 Move rdi, stack:0x0
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
