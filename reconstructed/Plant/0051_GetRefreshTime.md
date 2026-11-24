# System.Int32 GetRefreshTime(Reloaded.TreeStateActivities.GameplayActivity app, Reloaded.Gameplay.SeedType theSeedType, Reloaded.Gameplay.SeedType theImitaterType)

- 类：`Plant`
- 汇编行数：166

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rsi
	push rdi
	sub rsp,20h
	mov edi,edx
	mov rbx,rcx
	mov ecx,edi
	xor edx,edx
	mov esi,r8d
	call 00000001806859A0h
	test al,al
	je short 00000001806B1AEDh
	test rbx,rbx
	je near ptr 00000001806B1B9Dh
	xor edx,edx
	mov rcx,rbx
	call 00000001807DF9F0h
	test al,al
	jne short 00000001806B1AEDh
	xor eax,eax
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	cmp edi,30h
	jne near ptr 00000001806B1B91h
	cmp esi,0FFFFFFFFh
	je near ptr 00000001806B1B91h
	test rbx,rbx
	je near ptr 00000001806B1B9Dh
	mov edx,esi
	xor r8d,r8d
	mov rcx,rbx
	call 00000001807DD8A0h
	xor edx,edx
	mov rcx,rbx
	mov rdi,rax
	call 00000001807DF9F0h
	test al,al
	jne short 00000001806B1B4Fh
	test rdi,rdi
	je short 00000001806B1B9Dh
	movd xmm0,dword ptr [rdi+50h]
	cvtdq2ps xmm0,xmm0
	mulss xmm0,dword ptr [rbx+0DCh]
	cvttss2si eax,xmm0
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov rax,[rbx+0D0h]
	test rax,rax
	je short 00000001806B1B79h
	cmp dword ptr [rax+44h],4
	jne short 00000001806B1B79h
	test rdi,rdi
	je short 00000001806B1B9Dh
	mov eax,[rdi+58h]
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	test rdi,rdi
	je short 00000001806B1B9Dh
	mov eax,[rdi+54h]
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	test rbx,rbx
	je short 00000001806B1B9Dh
	mov edx,edi
	jmp near ptr 00000001806B1B0Ah
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -32
	006 Move rdi, rdx
	007 Move rbx, rcx
	008 Move rcx, rdi
	009 Move rdx, 0
	010 Move rsi, r8
	011 Call Challenge.IsZombieSeedType, rcx, rdx
	012 Compare rax, 0
	013 JumpIfEqual {28}
	014 Compare rbx, 0
	015 JumpIfEqual {83}
	016 Move rdx, 0
	017 Move rcx, rbx
	018 Call GameplayActivity.IsVersusMode, rcx, rdx
	019 Compare rax, 0
	020 JumpIfNotEqual {28}
	021 Move rax, 0
	022 Move rbx, stack:0x30
	023 Move rsi, stack:0x38
	024 ShiftStack 32
	025 Move rdi, stack:0x0
	026 ShiftStack 8
	027 Return rax
	028 Compare rdi, 48
	029 JumpIfNotEqual {79}
	030 Compare rsi, 18446744073709551615
	031 JumpIfEqual {79}
	032 Compare rbx, 0
	033 JumpIfEqual {83}
	034 Move rdx, rsi
	035 Move r8, 0
	036 Move rcx, rbx
	037 Call GameplayActivity.GetPlantDefinition, rcx, rdx
	038 Move rdx, 0
	039 Move rcx, rbx
	040 Move rdi, rax
	041 Call GameplayActivity.IsVersusMode, rcx, rdx
	042 Compare rax, 0
	043 JumpIfNotEqual {56}
	044 Compare rdi, 0
	045 JumpIfEqual {83}
	046 Move xmm0, [rdi+80]
	047 Move xmm0, xmm0
	048 Multiply xmm0, xmm0, [rbx+220]
	049 NotImplemented "cvttss2si eax,xmm0"
	050 Move rbx, stack:0x30
	051 Move rsi, stack:0x38
	052 ShiftStack 32
	053 Move rdi, stack:0x0
	054 ShiftStack 8
	055 Return rax
	056 Move rax, [rbx+208]
	057 Compare rax, 0
	058 JumpIfEqual {70}
	059 Compare [rax+68], 4
	060 JumpIfNotEqual {70}
	061 Compare rdi, 0
	062 JumpIfEqual {83}
	063 Move rax, [rdi+88]
	064 Move rbx, stack:0x30
	065 Move rsi, stack:0x38
	066 ShiftStack 32
	067 Move rdi, stack:0x0
	068 ShiftStack 8
	069 Return rax
	070 Compare rdi, 0
	071 JumpIfEqual {83}
	072 Move rax, [rdi+84]
	073 Move rbx, stack:0x30
	074 Move rsi, stack:0x38
	075 ShiftStack 32
	076 Move rdi, stack:0x0
	077 ShiftStack 8
	078 Return rax
	079 Compare rbx, 0
	080 JumpIfEqual {83}
	081 Move rdx, rdi
	082 Goto {35}
	083 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
