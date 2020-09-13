﻿namespace Nethereum.Geth.RPC
{
    public enum ApiMethods
    {
        admin_addPeer,
        admin_nodeInfo,
        admin_datadir,
        admin_peers,
        admin_startRPC,
        admin_setSolc,
        admin_startWS,
        admin_stopRPC,
        admin_stopWS,
        debug_blockProfile,
        debug_backtraceAt,
        debug_dumpBlock,
        debug_cpuProfile,
        debug_gcStats,
        debug_getBlockRlp,
        debug_goTrace,
        debug_memStats,
        debug_seedHash,
        debug_setBlockProfileRate,
        debug_stacks,
        debug_startCPUProfile,
        debug_startGoTrace,
        debug_stopCPUProfile,
        debug_stopGoTrace,
        debug_traceBlock,
        debug_traceBlockByNumber,
        debug_traceBlockByHash,
        debug_traceBlockFromFile,
        debug_traceTransaction,
        debug_verbosity,
        debug_vmodule,
        eth_pendingTransactions,
        miner_hashrate,
        miner_start,
        miner_stop,
        miner_setGasPrice,
        txpool_content,
        txpool_inspect,
        txpool_status
    }
}